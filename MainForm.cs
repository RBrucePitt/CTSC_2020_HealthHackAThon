using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Windows.Forms;

using System.Threading;
using System.IO;

namespace SAI_AM
{
    public partial class MainForm : Form
    {
        Thread threadRaw = null;
        Thread threadProc = null;
        bool threadRawDone = false;
        bool threadProcDone = false;

        int inputCount = 0;
        int endCount = 0;
        int curDisplayImage = 0;
        bool annotateMode = true;

        String aboutMsg =  "Segmenting Anatomic Image Process developed for " +
                            "Team SAI_AM for the 2020 CTSC Health-HackAThone on " +
                            "February 21-23, 2020.\n" +
                            "Team Members: Eric Taylor, Harry Snow, Hamiz Mir, Bruce Pitt\n";
        String helpMsg = "Help - select a patient file, then an image set, set the patient " +
                            "parameters and press Load Image Files, processing will occur as " +
                            "loading occurs.\n" +
                            "Click on an Image to zoom in, use the Structure Identification " +
                            "buttons to organize images by that structure. Green indicates " +
                            "normal, yellow indicates doesn't match known information, red " +
                            "indcates unknown structure.\n\n" +
                            "THIS TOOLS IS FOR NON DIAGNOSTIC USAGE TO ASSIST IN PRIORITIZING " +
                            "ANALYSIS OF POTENTIAL ISSUES IN THE IMAGES LOADED TO SPEED THE " +
                            "USER'S ASSESSMENT OF THE BEST TREATMENT AND EXPERTS TO CALL.";

        Dictionary<int, Bitmap> rawBitMaps = new Dictionary<int, Bitmap>();
        Dictionary<int, Bitmap> annoBitMaps = new Dictionary<int, Bitmap>();
        Dictionary<int, Bitmap> colorBitMaps = new Dictionary<int, Bitmap>();
        List<String> rawFileNames;

        Dictionary<int, String> partsReference = new Dictionary<int, string>();
        Dictionary<int, int> colorsReference = new Dictionary<int, int>();

        public MainForm()
        {
            InitializeComponent();
            buildReferenceDictionary();
        }

        private void Button_MF_Browse_Click(object sender, EventArgs e)
        {
            FolderBrowserDialog openDirDialog_SelectDir = new FolderBrowserDialog();
            openDirDialog_SelectDir.SelectedPath = "D:\\BrainScanning";

            if (openDirDialog_SelectDir.ShowDialog() == DialogResult.OK)
            {
                TextBox_MF_ImageLocatoin.Text = openDirDialog_SelectDir.SelectedPath;
            }

            this.Refresh();
        }

        private void Button_MF_LoadImageSet_Click(object sender, EventArgs e)
        {
            StartThreadRaw();
            StartThreadProc();
            Timer_MF_LoadDoneCheck.Enabled = true;
        }

        private void Button_MF_LoadPatient_Click(object sender, EventArgs e)
        {
            OpenFileDialog openFileDialog1 = new OpenFileDialog();

            openFileDialog1.InitialDirectory = "D:\\BrainScanning";
            openFileDialog1.Filter = "Patient files (*.txt)|*.txt|All files (*.*)|*.*";
            openFileDialog1.FilterIndex = 1;
            openFileDialog1.RestoreDirectory = true;

            if (openFileDialog1.ShowDialog() == DialogResult.OK)
            {
                TextBox_MF_PatientFile.Text = openFileDialog1.FileName;
                LoadPatientFile(TextBox_MF_PatientFile.Text);
            }
        }

        private void LoadPatientFile(String filePath)
        {
            TextBox_MF_PatientName.Text = "Patient Zero";
            TextBox_MF_DoctorId.Text = "Dr. Immediately";
            TextBox_MF_ControlNumber.Text = "9974CF123-002";
            TextBox_MF_Age.Text = "47";
            ComboBox_MF_Gender.SelectedIndex = 0;
            ComboBox_MF_SetArea.SelectedIndex = 0;
        }

        private void Button_MF_Exit_Click(object sender, EventArgs e)
        {
            if (threadRaw != null)
            {
                StopThreadRaw();
            }
            if (threadProc != null)
            {
                StopThreadProc();
            }
            this.Close();
        }

        private void StartThreadRaw()
        {
            threadRawDone = false;
            threadRaw = new Thread(runRawThread);
            threadRaw.Start();
        }

        private void StartThreadProc()
        {
            threadProcDone = false;
            threadProc = new Thread(runProcThread);
            threadProc.Start();
        }

        private void StopThreadRaw()
        {
            if (threadRaw != null)
            {
                threadRaw.Abort();
                Thread.Sleep(100);
            }
        }

        private void StopThreadProc()
        {
            if (threadProc != null)
            {
                threadProc.Abort();
                Thread.Sleep(100);
            }
        }

        private void PostRawThreadStop()
        {
            if (this.InvokeRequired)
            {
                // We're on a thread other than the GUI thread
                this.Invoke(new MethodInvoker(() => PostRawThreadStop()));
                return;
            }

            threadRaw = null;
            threadRawDone = true;
        }

        private void PostProcThreadStop()
        {
            if (this.InvokeRequired)
            {
                // We're on a thread other than the GUI thread
                try
                {
                    this.Invoke(new MethodInvoker(() => PostProcThreadStop()));
                }
                catch (Exception ex)
                {
                    threadProc = null;
                    threadProcDone = true;
                }
                return;
            }

            threadProc = null;
            threadProcDone = true;
        }


        private void PostProcThreadStatus(String msg)
        {
            if (this.InvokeRequired)
            {
                // We're on a thread other than the GUI thread
                this.Invoke(new MethodInvoker(() => PostProcThreadStatus(msg)));
            
                return;
            }

            TextBox_ProcStatus.Text = msg;
        }

        private void PostRawThreadStatus(String msg)
        {
            if (this.InvokeRequired)
            {
                // We're on a thread other than the GUI thread
                this.Invoke(new MethodInvoker(() => PostRawThreadStatus(msg)));
                return;
            }

            TextBox_Raw_Status.Text = msg;
        }

        private void Button_MF_Help_Click(object sender, EventArgs e)
        {
            MessageBox.Show(helpMsg, "Help");
        }

        private void Button_MF_About_Click(object sender, EventArgs e)
        {
            MessageBox.Show(aboutMsg, "About");
        }

        private void runRawThread()
        {
            PostProcThreadStatus("Loading Images");
            int imageCount = 0;
            rawBitMaps.Clear();

            rawFileNames = LoadFileNames(TextBox_MF_ImageLocatoin.Text, ".jpg");
            rawFileNames.Sort();
            endCount = rawFileNames.Count;
            for (int i = 0; i < rawFileNames.Count; i++)
            {
                PostRawThreadStatus(i.ToString() + ": Loading: " + rawFileNames[i]);
                LoadImageFile(rawFileNames[i], i, 0, false);
                imageCount++;
                inputCount++;
            }

            PostRawThreadStatus("Image Load Complete: Images: " + imageCount);

            curDisplayImage = imageCount / 2;

            PostRawThreadStop();
        }

        private void runProcThread()
        {
            annoBitMaps.Clear();
            colorBitMaps.Clear();

            PostProcThreadStatus("Waiting for Load");
            int imageCount = 0;
            while ((threadRaw != null) && (endCount == 0))
            {
                Thread.Sleep(100);
            }

            String newDirPath = TextBox_MF_ImageLocatoin.Text;
            int pos = newDirPath.LastIndexOf("\\");
            newDirPath = newDirPath.Substring(0, pos);

            PostProcThreadStatus("Starting Processing");
            while (imageCount < endCount) 
            {
                String rawFileName = rawFileNames.ElementAt(imageCount);
                PostProcThreadStatus("Processing Image: " + imageCount);
                int pos1 = rawFileName.IndexOf("_z");
                if (pos1 != -1)
                {
                    String fileNum = rawFileName.Substring(pos1 + 2, 4);
                    String newPath1 = newDirPath + "\\" + "Annotated\\" + "Composite-1" + fileNum + ".jpg";
                    LoadImageFile(newPath1, imageCount, 1, true);
                    String newPath2 = newDirPath + "\\" + "Color\\" + "t-1" + fileNum + ".jpg";
                    LoadImageFile(newPath2, imageCount, 1, false);
                    imageCount++;
                }
            }

            PostRawThreadStatus("Image Processing Complete: Images: " + imageCount);
            Thread.Sleep(100);
            PostProcThreadStop();
        }

        private List<String> LoadFileNames(String dirPath, String extension)
        {
            List<String> filesFound = new List<String>();
            try
            {
                foreach (string fName in Directory.GetFiles(dirPath))
                {
                    if (Path.GetExtension(fName) == extension)
                    {
                        filesFound.Add(fName);
                    }
                }

            }
            catch (System.Exception)
            {
                //PostFileStatusUpdateMessage("Dir Scan Exception: " + excpt.Message);
            }

            return (filesFound);
        }

        private void LoadImageFile(String imagePath, int itemNo, int side, bool annoOrColor)
        {
            if (!File.Exists(imagePath))
                return;

            Bitmap nextImage = new Bitmap(imagePath);
            if (side == 0)
            {
                rawBitMaps.Add(itemNo, nextImage);
                PictureBox_MF_Raw.Image = nextImage;
                PictureBox_MF_Raw.SizeMode = PictureBoxSizeMode.StretchImage;
                Thread.Sleep(100);
            }
            else if (side == 1)
            {
                if (annoOrColor)
                {
                    annoBitMaps.Add(itemNo, nextImage);
                    PictureBox_MF_Processed.Image = nextImage;
                    PictureBox_MF_Processed.SizeMode = PictureBoxSizeMode.StretchImage;
                    Thread.Sleep(50);
                }
                else
                {
                    colorBitMaps.Add(itemNo, nextImage);
                    PictureBox_MF_Processed.Image = nextImage;
                    PictureBox_MF_Processed.SizeMode = PictureBoxSizeMode.StretchImage;
                    Thread.Sleep(50);
                }

            }
        }

        private void Button_MF_Raw_Left_Click(object sender, EventArgs e)
        {
            if (curDisplayImage == 0)
                return;
            curDisplayImage--;
            DisplayManualImage();
        }

        private void Button_MF_Raw_Right_Click(object sender, EventArgs e)
        {
            if (curDisplayImage >= endCount)
                return;
            curDisplayImage++;
            DisplayManualImage();
        }

        private void Button_MF_Proc_Left_Click(object sender, EventArgs e)
        {
            if (curDisplayImage == 0)
                return;
            if (curDisplayImage > endCount)
                return;
            curDisplayImage--;
            DisplayManualImage();
        }

        private void Button_MF_Proc_Right_Click(object sender, EventArgs e)
        {
            if (curDisplayImage > endCount)
                return;
            curDisplayImage++;
            DisplayManualImage();
        }

        private void DisplayManualImage()
        {
            PictureBox_MF_Raw.Image = rawBitMaps.ElementAt(curDisplayImage).Value;
            PictureBox_MF_Raw.SizeMode = PictureBoxSizeMode.StretchImage;
            TextBox_MF_RawImageNo.Text = (curDisplayImage + 1).ToString();

            if (annotateMode)
            {
                if (annoBitMaps.ContainsKey(curDisplayImage))
                {
                    PictureBox_MF_Processed.Image = annoBitMaps.ElementAt(curDisplayImage).Value;
                    PictureBox_MF_Processed.SizeMode = PictureBoxSizeMode.StretchImage;
                    TextBox_MF_ProcImageNo.Text = (curDisplayImage + 1).ToString();
                }
                else
                {
                    PictureBox_MF_Processed.Image = rawBitMaps.ElementAt(curDisplayImage).Value;
                    PictureBox_MF_Processed.SizeMode = PictureBoxSizeMode.StretchImage;
                    TextBox_MF_ProcImageNo.Text = "N/A";
                }
            }
            else
            {
                if (colorBitMaps.ContainsKey(curDisplayImage))
                {
                    PictureBox_MF_Processed.Image = colorBitMaps.ElementAt(curDisplayImage).Value;
                    PictureBox_MF_Processed.SizeMode = PictureBoxSizeMode.StretchImage;
                    TextBox_MF_ProcImageNo.Text = (curDisplayImage + 1).ToString();
                }
                else
                {
                    PictureBox_MF_Processed.Image = rawBitMaps.ElementAt(curDisplayImage).Value;
                    PictureBox_MF_Processed.SizeMode = PictureBoxSizeMode.StretchImage;
                    TextBox_MF_ProcImageNo.Text = "N/A";
                }
            }
        }

        private void Button_MF_AnnotateMode_Click(object sender, EventArgs e)
        {
            annotateMode = true;
            DisplayManualImage();
        }

        private void Button_MF_ColorMode_Click(object sender, EventArgs e)
        {
            annotateMode = false;
            DisplayManualImage();
        }

        private Point adjustLocationLeft(int xStretch, int yStretch)
        {
            Point adjustedPoint = new Point();

            int boxWidth = PictureBox_MF_Raw.Width;
            int boxHeight = PictureBox_MF_Raw.Height;

            int imageWidth = PictureBox_MF_Raw.Image.Width;
            int imageHeight = PictureBox_MF_Raw.Image.Height;

            float wRatio = (float)imageWidth / (float)boxWidth;
            float hRatio = (float)imageHeight / (float)boxHeight;

            float retX = xStretch;
            float retY = yStretch;

            retX *= wRatio;
            retY *= hRatio;

            adjustedPoint.X = (int)retX;
            adjustedPoint.Y = (int)retY;

            if (adjustedPoint.X > imageWidth)
            {
                adjustedPoint.X = imageWidth - 2;
            }
            if (adjustedPoint.Y > imageHeight)
            {
                adjustedPoint.Y = imageHeight - 2;
            }

            return (adjustedPoint);
        }

        private Point adjustLocationRight(int xStretch, int yStretch)
        {
            Point adjustedPoint = new Point();

            int boxWidth = PictureBox_MF_Raw.Width;
            int boxHeight = PictureBox_MF_Raw.Height;

            int imageWidth = PictureBox_MF_Raw.Image.Width;
            int imageHeight = PictureBox_MF_Raw.Image.Height;

            if (annotateMode)
            {
                imageWidth = colorBitMaps.ElementAt(curDisplayImage).Value.Width;
                imageHeight = colorBitMaps.ElementAt(curDisplayImage).Value.Height;
            }

            float wRatio = (float)imageWidth / (float)boxWidth;
            float hRatio = (float)imageHeight / (float)boxHeight;

            float retX = xStretch;
            float retY = yStretch;

            retX *= wRatio;
            retY *= hRatio;

            adjustedPoint.X = (int)retX;
            adjustedPoint.Y = (int)retY;

            if (adjustedPoint.X > imageWidth)
            {
                adjustedPoint.X = imageWidth - 2;
            }
            if (adjustedPoint.Y > imageHeight)
            {
                adjustedPoint.Y = imageHeight - 2;
            }

            return (adjustedPoint);
        }

        private void PictureBox_MF_Processed_MouseMove(object sender, MouseEventArgs e)
        {
            if (threadRaw != null)
                return;

            TextBox_X_Right.Text = e.Location.X.ToString() ;
            TextBox_Y_Right.Text = e.Location.Y.ToString();

            int xOfs = e.Location.X;
            int yOfs = e.Location.Y;

            if (rawBitMaps.Count < 1)
                return;

            Point adjustedPoint = adjustLocationRight(xOfs, yOfs);

            try
            {
                System.Drawing.Color color1 = ((Bitmap)PictureBox_MF_Processed.Image).GetPixel(adjustedPoint.X, adjustedPoint.Y);
                TextBox_Right_Color.Text = color1.ToString();
                TextBox_MF_BrainArea.Text = "";
                if (annotateMode == false)
                {
                    if (partsReference.ContainsKey(color1.R))
                    {
                        TextBox_MF_BrainArea.Text = partsReference[color1.R];
                    }
                }
            }
            catch (Exception ex)
            {
                TextBox_Right_Color.Text = "";
            }

        }

        private void PictureBox_MF_Raw_MouseMove(object sender, MouseEventArgs e)
        {
            if (threadRaw != null)
                return;


            TextBox_MF_X_Left.Text = e.Location.X.ToString();
            TextBox_MF_Y_Left.Text = e.Location.Y.ToString();

            int xOfs = e.Location.X;
            int yOfs = e.Location.Y;

            if (rawBitMaps.Count < 1)
                return;

            Point adjustedPoint = adjustLocationLeft(xOfs, yOfs);

            try
            {
                System.Drawing.Color color0 = ((Bitmap)PictureBox_MF_Raw.Image).GetPixel(adjustedPoint.X, adjustedPoint.Y);
                TextBox_Left_Color.Text = color0.ToString();
            }
            catch (Exception ex)
            {
                TextBox_Left_Color.Text = "";
            }
        }

        private void processColorPallette2Index()
        {
            //TextBox_MF_BrainArea.Text = "Indexing...";
            for (int imageNo = 0; imageNo < colorBitMaps.Count; imageNo++)
            {
                //TextBox_MF_BrainArea.Text = "Indexing..." + imageNo;
                processColorPallette(colorBitMaps.ElementAt(imageNo).Value);
            }
            TextBox_MF_BrainArea.Text = "";
        }

        private void processColorPallette(Bitmap nextImage)
        {
            int colorsFound = 0;
            int width = nextImage.Width;
            int height = nextImage.Height;


            for (int xPos = 0; xPos < width; xPos++)
            {
                for (int yPos = 0; yPos < height; yPos++)
                {
                    System.Drawing.Color color = nextImage.GetPixel(xPos, yPos);
                    if ((color.R == color.G) && (color.G == color.B))
                    {
                        if (!colorsReference.ContainsKey(color.R))
                        {
                            colorsReference.Add(color.R, colorsFound);
                            colorsFound++;
                        }
                    }
                }
            }
        }

        private void buildReferenceDictionary()
        {

            partsReference.Clear();
            colorsReference.Clear();

            partsReference.Add( 0 , "");
            partsReference.Add( 1 , "TL hippocampus R");
            partsReference.Add( 2 , "TL hippocampus L");
            partsReference.Add( 3 , "TL amygdala R");
            partsReference.Add( 4 , "TL amygdala L");
            partsReference.Add( 5 , "TL anterior temporal lobe medial part R");
            partsReference.Add( 6 , "TL anterior temporal lobe medial part L");
            partsReference.Add( 7 , "TL anterior temporal lobe lateral part R");
            partsReference.Add( 8 , "TL anterior temporal lobe lateral part L");
            partsReference.Add( 9 , "TL parahippocampal and ambient gyrus R ");
            partsReference.Add( 10 , "TL parahippocampal and ambient gyrus L ");
            partsReference.Add( 11 , "TL superior temporal gyrus middle part R");
            partsReference.Add( 12 , "TL superior temporal gyrus middle part L");
            partsReference.Add( 13 , "TL middle and inferior temporal gyrus R");
            partsReference.Add( 14 , "TL middle and inferior temporal gyrus L");
            partsReference.Add( 15 , "TL fusiform gyrus R ");
            partsReference.Add( 16 , "TL fusiform gyrus L ");
            partsReference.Add( 17 , "cerebellum R ");
            partsReference.Add( 18 , "cerebellum L ");
            partsReference.Add( 19 , "brainstem excluding substantia nigra ");
            partsReference.Add( 20 , "insula posterior long gyrus L ");
            partsReference.Add( 21 , "insula posterior long gyrus R ");
            partsReference.Add( 22 , "OL lateral remainder occipital lobe L ");
            partsReference.Add( 23 , "OL lateral remainder occipital lobe R ");
            partsReference.Add( 24 , "CG anterior cingulate gyrus L");
            partsReference.Add( 25 , "CG anterior cingulate gyrus R");
            partsReference.Add( 26 , "CG posterior cingulate gyrus L");
            partsReference.Add( 27 , "CG posterior cingulate gyrus R");
            partsReference.Add( 28 , "FL middle frontal gyrus L");
            partsReference.Add( 29 , "FL middle frontal gyrus R");
            partsReference.Add( 30 , "TL posterior temporal lobe L");
            partsReference.Add( 31 , "TL posterior temporal lobe R");
            partsReference.Add( 32 , "PL angular gyrus L ");
            partsReference.Add( 33 , "PL angular gyrus R ");
            partsReference.Add( 34 , "caudate nucleus L");
            partsReference.Add( 35 , "caudate nucleus R");
            partsReference.Add( 36 , "nucleus accumbens L");
            partsReference.Add( 37 , "nucleus accumbens R");
            partsReference.Add( 38 , "putamen L ");
            partsReference.Add( 39 , "putamen R ");
            partsReference.Add( 40 , "thalamus L ");
            partsReference.Add( 41 , "thalamus R ");
            partsReference.Add( 42 , "pallidum L ");
            partsReference.Add( 43 , "pallidum R ");
            partsReference.Add( 44 , "corpus callosum ");
            partsReference.Add( 45 , "Lateral ventricle excluding temporal horn R ");
            partsReference.Add( 46 , "Lateral ventricle excluding temporal horn L ");
            partsReference.Add( 47 , "Lateral ventricle temporal horn R");
            partsReference.Add( 48 , "Lateral ventricle temporal horn L");
            partsReference.Add( 49 , "Third ventricle ");
            partsReference.Add( 50 , "FL precentral gyrus L ");
            partsReference.Add( 51 , "FL precentral gyrus R ");
            partsReference.Add( 52 , "FL straight gyrus L ");
            partsReference.Add( 53 , "FL straight gyrus R ");
            partsReference.Add( 54 , "FL anterior orbital gyrus L");
            partsReference.Add( 55 , "FL anterior orbital gyrus R");
            partsReference.Add( 56 , "FL inferior frontal gyrus L");
            partsReference.Add( 57 , "FL inferior frontal gyrus R");
            partsReference.Add( 58 , "FL superior frontal gyrus L");
            partsReference.Add( 59 , "FL superior frontal gyrus R");
            partsReference.Add( 60 , "PL postcentral gyrus L ");
            partsReference.Add( 61 , "PL postcentral gyrus R ");
            partsReference.Add( 62 , "PL superior parietal gyrus L");
            partsReference.Add( 63 , "PL superior parietal gyrus R");
            partsReference.Add( 64 , "OL lingual gyrus L ");
            partsReference.Add( 65 , "OL lingual gyrus R ");
            partsReference.Add( 66 , "OL cuneus L");
            partsReference.Add( 67 , "OL cuneus R");
            partsReference.Add( 68 , "FL medial orbital gyrus L");
            partsReference.Add( 69 , "FL medial orbital gyrus R");
            partsReference.Add( 70 , "FL lateral orbital gyrus L");
            partsReference.Add( 71 , "FL lateral orbital gyrus R");
            partsReference.Add( 72 , "FL posterior orbital gyrus L");
            partsReference.Add( 73 , "FL posterior orbital gyrus R");
            partsReference.Add( 74 , "substantia nigra L");
            partsReference.Add( 75 , "substantia nigra R");
            partsReference.Add( 76 , "FL subgenual frontal cortex L");
            partsReference.Add( 77 , "FL subgenual frontal cortex R");
            partsReference.Add( 78 , "FL subcallosal area L ");
            partsReference.Add( 79 , "FL subcallosal area R ");
            partsReference.Add( 80 , "FL pre - subgenual frontal cortex L ");
            partsReference.Add( 81 , "FL pre - subgenual frontal cortex R ");
            partsReference.Add( 82 , "TL superior temporal gyrus anterior part L");
            partsReference.Add( 83 , "TL superior temporal gyrus anterior part R");
            partsReference.Add( 84 , "PL supramarginal gyrus L ");
            partsReference.Add( 85 , "PL supramarginal gyrus R ");
            partsReference.Add( 86 , "insula anterior short gyrus L ");
            partsReference.Add( 87 , "insula anterior short gyrus R ");
            partsReference.Add( 88 , "insula middle short gyrus L ");
            partsReference.Add( 89 , "insula middle short gyrus R ");
            partsReference.Add( 90 , "insula posterior short gyrus L ");
            partsReference.Add( 91 , "insula posterior short gyrus R ");
            partsReference.Add( 92 , "insula anterior inferior cortex L");
            partsReference.Add( 93 , "insula anterior inferior cortex R");
            partsReference.Add( 94 , "insula anterior long gyrus L ");
            partsReference.Add( 95 , "insula anterior long gyrus R ");



        }

        private void Timer_MF_LoadDoneCheck_Tick(object sender, EventArgs e)
        {
            if ((threadRawDone) && (threadProcDone))
            {
                processColorPallette2Index();
                DisplayManualImage();
                Timer_MF_LoadDoneCheck.Enabled = false;
            }
        }
    }



}


