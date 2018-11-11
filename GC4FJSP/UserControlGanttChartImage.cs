﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;


namespace GC4FJSP
{
    using ListGanttItem = List<GanttItemType>;
    public partial class UserControlGanttChartImage : UserControl
    {
        int[,] arrColor_ = new int[,]{
            {176,23,31},
            {220,20,60},
            {255,182,193},
            {255,174,185},
            {238,162,173},
            {205,140,149},
            {139,95,101},
            {255,192,203},
            {255,181,197},
            {238,169,184},
            {205,145,158},
            {139,99,108},
            {219,112,147},
            {255,130,171},
            {238,121,159},
            {205,104,137},
            {139,71,93},
            {255,240,245},
            {238,224,229},
            {205,193,197},
            {139,131,134},
            {255,62,150},
            {238,58,140},
            {205,50,120},
            {139,34,82},
            {255,105,180},
            {255,110,180},
            {238,106,167},
            {205,96,144},
            {139,58,98},
            {135,38,87},
            {255,20,147},
            {238,18,137},
            {205,16,118},
            {139,10,80},
            {255,52,179},
            {238,48,167},
            {205,41,144},
            {139,28,98},
            {199,21,133},
            {208,32,144},
            {218,112,214},
            {255,131,250},
            {238,122,233},
            {205,105,201},
            {139,71,137},
            {216,191,216},
            {255,225,255},
            {238,210,238},
            {205,181,205},
            {139,123,139},
            {255,187,255},
            {238,174,238},
            {205,150,205},
            {139,102,139},
            {221,160,221},
            {238,130,238},
            {255,0,255},
            {238,0,238},
            {205,0,205},
            {139,0,139},
            {128,0,128},
            {186,85,211},
            {224,102,255},
            {209,95,238},
            {180,82,205},
            {122,55,139},
            {148,0,211},
            {153,50,204},
            {191,62,255},
            {178,58,238},
            {154,50,205},
            {104,34,139},
            {75,0,130},
            {138,43,226},
            {155,48,255},
            {145,44,238},
            {125,38,205},
            {85,26,139},
            {147,112,219},
            {171,130,255},
            {159,121,238},
            {137,104,205},
            {93,71,139},
            {72,61,139},
            {132,112,255},
            {123,104,238},
            {106,90,205},
            {131,111,255},
            {122,103,238},
            {105,89,205},
            {71,60,139},
            {248,248,255},
            {230,230,250},
            {0,0,255},
            {0,0,238},
            {0,0,205},
            {0,0,139},
            {0,0,128},
            {25,25,112},
            {61,89,171},
            {65,105,225},
            {72,118,255},
            {67,110,238},
            {58,95,205},
            {39,64,139},
            {100,149,237},
            {176,196,222},
            {202,225,255},
            {188,210,238},
            {162,181,205},
            {110,123,139},
            {119,136,153},
            {112,128,144},
            {198,226,255},
            {185,211,238},
            {159,182,205},
            {108,123,139},
            {30,144,255},
            {28,134,238},
            {24,116,205},
            {16,78,139},
            {240,248,255},
            {70,130,180},
            {99,184,255},
            {92,172,238},
            {79,148,205},
            {54,100,139},
            {135,206,250},
            {176,226,255},
            {164,211,238},
            {141,182,205},
            {96,123,139},
            {135,206,255},
            {126,192,238},
            {108,166,205},
            {74,112,139},
            {135,206,235},
            {0,191,255},
            {0,178,238},
            {0,154,205},
            {0,104,139},
            {51,161,201},
            {173,216,230},
            {191,239,255},
            {178,223,238},
            {154,192,205},
            {104,131,139},
            {176,224,230},
            {152,245,255},
            {142,229,238},
            {122,197,205},
            {83,134,139},
            {0,245,255},
            {0,229,238},
            {0,197,205},
            {0,134,139},
            {95,158,160},
            {0,206,209},
            {240,255,255},
            {224,238,238},
            {193,205,205},
            {131,139,139},
            {224,255,255},
            {209,238,238},
            {180,205,205},
            {122,139,139},
            {187,255,255},
            {174,238,238},
            {150,205,205},
            {102,139,139},
            {47,79,79},
            {151,255,255},
            {141,238,238},
            {121,205,205},
            {82,139,139},
            {0,255,255},
            {0,238,238},
            {0,205,205},
            {0,139,139},
            {0,128,128},
            {72,209,204},
            {32,178,170},
            {3,168,158},
            {64,224,208},
            {128,138,135},
            {0,199,140},
            {127,255,212},
            {118,238,198},
            {102,205,170},
            {69,139,116},
            {0,250,154},
            {245,255,250},
            {0,255,127},
            {0,238,118},
            {0,205,102},
            {0,139,69},
            {60,179,113},
            {84,255,159},
            {78,238,148},
            {67,205,128},
            {46,139,87},
            {0,201,87},
            {189,252,201},
            {61,145,64},
            {240,255,240},
            {224,238,224},
            {193,205,193},
            {131,139,131},
            {143,188,143},
            {193,255,193},
            {180,238,180},
            {155,205,155},
            {105,139,105},
            {152,251,152},
            {154,255,154},
            {144,238,144},
            {124,205,124},
            {84,139,84},
            {50,205,50},
            {34,139,34},
            {0,255,0},
            {0,238,0},
            {0,205,0},
            {0,139,0},
            {0,128,0},
            {0,100,0},
            {48,128,20},
            {124,252,0},
            {127,255,0},
            {118,238,0},
            {102,205,0},
            {69,139,0},
            {173,255,47},
            {202,255,112},
            {188,238,104},
            {162,205,90},
            {110,139,61},
            {85,107,47},
            {107,142,35},
            {192,255,62},
            {179,238,58},
            {154,205,50},
            {105,139,34},
            {255,255,240},
            {238,238,224},
            {205,205,193},
            {139,139,131},
            {245,245,220},
            {255,255,224},
            {238,238,209},
            {205,205,180},
            {139,139,122},
            {250,250,210},
            {255,255,0},
            {238,238,0},
            {205,205,0},
            {139,139,0},
            {128,128,105},
            {128,128,0},
            {189,183,107},
            {255,246,143},
            {238,230,133},
            {205,198,115},
            {139,134,78},
            {240,230,140},
            {238,232,170},
            {255,250,205},
            {238,233,191},
            {205,201,165},
            {139,137,112},
            {255,236,139},
            {238,220,130},
            {205,190,112},
            {139,129,76},
            {227,207,87},
            {255,215,0},
            {238,201,0},
            {205,173,0},
            {139,117,0},
            {255,248,220},
            {238,232,205},
            {205,200,177},
            {139,136,120},
            {218,165,32},
            {255,193,37},
            {238,180,34},
            {205,155,29},
            {139,105,20},
            {184,134,11},
            {255,185,15},
            {238,173,14},
            {205,149,12},
            {139,101,8},
            {255,165,0},
            {238,154,0},
            {205,133,0},
            {139,90,0},
            {255,250,240},
            {253,245,230},
            {245,222,179},
            {255,231,186},
            {238,216,174},
            {205,186,150},
            {139,126,102},
            {255,228,181},
            {255,239,213},
            {255,235,205},
            {255,222,173},
            {238,207,161},
            {205,179,139},
            {139,121,94},
            {252,230,201},
            {210,180,140},
            {156,102,31},
            {255,153,18},
            {250,235,215},
            {255,239,219},
            {238,223,204},
            {205,192,176},
            {139,131,120},
            {222,184,135},
            {255,211,155},
            {238,197,145},
            {205,170,125},
            {139,115,85},
            {255,228,196},
            {238,213,183},
            {205,183,158},
            {139,125,107},
            {227,168,105},
            {237,145,33},
            {255,140,0},
            {255,127,0},
            {238,118,0},
            {205,102,0},
            {139,69,0},
            {255,128,0},
            {255,165,79},
            {238,154,73},
            {205,133,63},
            {139,90,43},
            {250,240,230},
            {255,218,185},
            {238,203,173},
            {205,175,149},
            {139,119,101},
            {255,245,238},
            {238,229,222},
            {205,197,191},
            {139,134,130},
            {244,164,96},
            {199,97,20},
            {210,105,30},
            {255,127,36},
            {238,118,33},
            {205,102,29},
            {139,69,19},
            {41,36,33},
            {255,125,64},
            {255,97,3},
            {138,54,15},
            {160,82,45},
            {255,130,71},
            {238,121,66},
            {205,104,57},
            {139,71,38},
            {255,160,122},
            {238,149,114},
            {205,129,98},
            {139,87,66},
            {255,127,80},
            {255,69,0},
            {238,64,0},
            {205,55,0},
            {139,37,0},
            {94,38,18},
            {233,150,122},
            {255,140,105},
            {238,130,98},
            {205,112,84},
            {139,76,57},
            {255,114,86},
            {238,106,80},
            {205,91,69},
            {139,62,47},
            {138,51,36},
            {255,99,71},
            {238,92,66},
            {205,79,57},
            {139,54,38},
            {250,128,114},
            {255,228,225},
            {238,213,210},
            {205,183,181},
            {139,125,123},
            {255,250,250},
            {238,233,233},
            {205,201,201},
            {139,137,137},
            {188,143,143},
            {255,193,193},
            {238,180,180},
            {205,155,155},
            {139,105,105},
            {240,128,128},
            {205,92,92},
            {255,106,106},
            {238,99,99},
            {139,58,58},
            {205,85,85},
            {165,42,42},
            {255,64,64},
            {238,59,59},
            {205,51,51},
            {139,35,35},
            {178,34,34},
            {255,48,48},
            {238,44,44},
            {205,38,38},
            {139,26,26},
            {255,0,0},
            {238,0,0},
            {205,0,0},
            {139,0,0},
            {128,0,0},
            {142,56,142},
            {113,113,198},
            {125,158,192},
            {56,142,142},
            {113,198,113},
            {142,142,56},
            {197,193,170},
            {198,113,113},
            {85,85,85},
            {30,30,30},
            {40,40,40},
            {81,81,81},
            {91,91,91},
            {132,132,132},
            {142,142,142},
            {170,170,170},
            {183,183,183},
            {193,193,193},
            {234,234,234},
            {244,244,244},
            {255,255,255},
            {245,245,245},
            {220,220,220},
            {211,211,211},
            {192,192,192},
            {169,169,169},
            {128,128,128},
            {105,105,105},
            {0,0,0},
            {252,252,252},
            {250,250,250},
            {247,247,247},
            {245,245,245},
            {242,242,242},
            {240,240,240},
            {237,237,237},
            {235,235,235},
            {232,232,232},
            {229,229,229},
            {227,227,227},
            {224,224,224},
            {222,222,222},
            {219,219,219},
            {217,217,217},
            {214,214,214},
            {212,212,212},
            {209,209,209},
            {207,207,207},
            {204,204,204},
            {201,201,201},
            {199,199,199},
            {196,196,196},
            {194,194,194},
            {191,191,191},
            {189,189,189},
            {186,186,186},
            {184,184,184},
            {181,181,181},
            {179,179,179},
            {176,176,176},
            {173,173,173},
            {171,171,171},
            {168,168,168},
            {166,166,166},
            {163,163,163},
            {161,161,161},
            {158,158,158},
            {156,156,156},
            {153,153,153},
            {150,150,150},
            {148,148,148},
            {145,145,145},
            {143,143,143},
            {140,140,140},
            {138,138,138},
            {135,135,135},
            {133,133,133},
            {130,130,130},
            {127,127,127},
            {125,125,125},
            {122,122,122},
            {120,120,120},
            {117,117,117},
            {115,115,115},
            {112,112,112},
            {110,110,110},
            {107,107,107},
            {105,105,105},
            {102,102,102},
            {99,99,99},
            {97,97,97},
            {94,94,94},
            {92,92,92},
            {89,89,89},
            {87,87,87},
            {84,84,84},
            {82,82,82},
            {79,79,79},
            {77,77,77},
            {74,74,74},
            {71,71,71},
            {69,69,69},
            {66,66,66},
            {64,64,64},
            {61,61,61},
            {59,59,59},
            {56,56,56},
            {54,54,54},
            {51,51,51},
            {48,48,48},
            {46,46,46},
            {43,43,43},
            {41,41,41},
            {38,38,38},
            {36,36,36},
            {33,33,33},
            {31,31,31},
            {28,28,28},
            {26,26,26},
            {23,23,23},
            {20,20,20},
            {18,18,18},
            {15,15,15},
            {13,13,13},
            {10,10,10},
            {8,8,8},
            {5,5,5},
            {3,3,3}
        };


        private GanttDataSetType GanttDataSet_ = new GanttDataSetType();
        private float ChartAreaX_;
        private float ChartAreaY_;
        private float ChartWidth_;
        private float ChartHeight_;

        private int nGroupCnt_;
        private int nMakespan_;

        RectangleF[] OperationRects_ = new RectangleF[] { };
        List<RectangleF> IndicateRect_ = new List<RectangleF>();

        private Graphics Graphic_;
        private Image Img_;

        private string ColorMode_;
        public string ColorMode
        {
            get
            {
                return ColorMode_;
            }
            set
            {
                ColorMode_ = value;
                this.Invalidate();
            }
        }

        public Image DrawExImage { get { return Img_; } }
        public Graphics DrawExGraphic { get { return Graphic_; } }


        public UserControlGanttChartImage()
        {
            InitializeComponent();
            ResizeRedraw = true;
        }

        // Event of Load
        private void UserControlGanttChartImage_Load(object sender, EventArgs e)
        {
            try
            {
                this.SetStyle(ControlStyles.AllPaintingInWmPaint, true);
                this.SetStyle(ControlStyles.UserPaint, true);
                this.UpdateStyles();
            }
            catch (Exception error)
            {
                MessageBox.Show(error.Message + "\n", "Error Display", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        public void ChangeSize(int nWidth, int nHeight)
        {
            this.Size = new System.Drawing.Size(nWidth, nHeight);
        }


        public void InitData(string GanttDataFile)
        {
            GanttDataSet_.InitData(GanttDataFile);
            OperationRects_ = new RectangleF[GanttDataSet_.GetGanttData().Count];
        }

        public void InitializeGraphicVariables(int nWidth, int nHeight)
        {
            Img_ = new Bitmap(nWidth, nHeight);
            Graphic_ = Graphics.FromImage(Img_);
        }

        private void UserControlGanttChartImage_Paint(object sender, PaintEventArgs e)
        {
            DrawGanttChart(this.ClientRectangle.Width, this.ClientRectangle.Height);
            e.Graphics.DrawImage(Img_, this.ClientRectangle);
        }

        private void DrawGanttChart(int nWidth, int nHeight)
        {
            InitializeGraphicVariables(nWidth, nHeight);

            int nOffset = 30;
            ChartAreaX_ = nOffset;
            ChartAreaY_ = nOffset;
            ChartWidth_ = this.Size.Width - (ChartAreaX_ + nOffset);
            ChartHeight_ = this.Size.Height - (ChartAreaY_ + nOffset);

            if (GanttDataSet_.GetGanttData().Count != 0)
            {
                DrawMarkingAndLabel(Graphic_);
                DrawContents(Graphic_);
            }

            DrawChartArea(Graphic_);
        }

        private void DrawChartArea(Graphics g)
        {
            // black, 3
            Pen PenAxis = new Pen(Color.Black, 3F);
            g.DrawRectangle(PenAxis, ChartAreaX_, ChartAreaY_, ChartWidth_, ChartHeight_);
        }

        private void DrawMarkingAndLabel(Graphics g)
        {
            nGroupCnt_ = -1;
            nMakespan_ = -1;

            foreach (GanttItemType Item in GanttDataSet_.GetGanttData())
            {
                if (nGroupCnt_ < Int32.Parse(Item.Machine))
                {
                    nGroupCnt_ = Int32.Parse(Item.Machine);
                }
                if (nMakespan_ < Item.End)
                {
                    nMakespan_ = Item.End;
                }
            }

            //if (nGroupCnt_ >= 1) nGroupCnt_ += 1;

            // Y Axis grid & label
            float GridHeight = ChartHeight_ / nGroupCnt_;
            Pen PenYGrid = new Pen(Color.Black, 1.5F);

            // Set format of string.
            StringFormat FormatYLabel = new StringFormat();
            FormatYLabel.Alignment = StringAlignment.Far;
            FormatYLabel.LineAlignment = StringAlignment.Center;
            Font FontYLabel = new Font("Arial", 10, FontStyle.Regular);

            for (int i = 1; i <= nGroupCnt_; i++)
            {
                g.DrawLine(PenYGrid, ChartAreaX_, (ChartAreaY_ + ChartHeight_ - GridHeight * i), (ChartAreaX_ + ChartWidth_), (ChartAreaY_ + ChartHeight_ - GridHeight * i));
                g.DrawString(String.Format("{0}{1}", 'M', i.ToString()), FontYLabel, Brushes.Black, ChartAreaX_, ChartAreaY_ + GridHeight * i - GridHeight / 2, FormatYLabel);
            }

            // X Axis grid & label
            float fWidthUnit = ChartWidth_ / nMakespan_;
            Pen PenXGrid = new Pen(Color.Gray, 0.5F);
            Font FontXLabel = new Font("Arial", 10, FontStyle.Regular);
            StringFormat FormatXLabel = new StringFormat();
            FormatXLabel.Alignment = StringAlignment.Center;
            FormatXLabel.LineAlignment = StringAlignment.Near;

            int nStep = 100;
            //int nStep = Convert.ToInt32(Math.Pow(10.0, Math.Log10(nMakespan_)));

            for (int i = 0; i < nMakespan_; i += nStep)
            {
                g.DrawLine(PenXGrid, ChartAreaX_ + fWidthUnit * i, ChartAreaY_, ChartAreaX_ + fWidthUnit * i, ChartAreaY_ + ChartHeight_);
                if (i % 500 == 0)
                    g.DrawString(i.ToString(), FontXLabel, Brushes.Black, ChartAreaX_ + fWidthUnit * i, ChartAreaY_ + ChartHeight_ + ChartAreaY_ * 0.05F, FormatXLabel);
            }
        }

        private void DrawContents(Graphics g)
        {
            float fWidthUnit = ChartWidth_ / nMakespan_;
            float fHeightUnit = ChartHeight_ / nGroupCnt_;


            Font f = new Font("Arial", 8, FontStyle.Regular);
            // Set format of string.
            StringFormat drawFormat = new StringFormat();
            drawFormat.Alignment = StringAlignment.Near;
            drawFormat.LineAlignment = StringAlignment.Center;

            // grid ( y only )
            float GridHeight = ChartHeight_ / nGroupCnt_;
            Pen PenContent = new Pen(Color.Black, 1.5F);

            for (int i = 0; i < GanttDataSet_.GetGanttData().Count; i++)
            {
                OperationRects_[i].X = ChartAreaX_ + fWidthUnit * GanttDataSet_.GetGanttData()[i].Start;
                OperationRects_[i].Y = ChartAreaY_ + GridHeight * (Int32.Parse(GanttDataSet_.GetGanttData()[i].Machine) - 1) + GridHeight * 0.15F;
                OperationRects_[i].Width = fWidthUnit * (GanttDataSet_.GetGanttData()[i].End - GanttDataSet_.GetGanttData()[i].Start);
                OperationRects_[i].Height = GridHeight * 0.7F;

                int nColorNum = 0;
                if (ColorMode_ == "LOT")
                {
                    nColorNum = GanttDataSet_.GetGanttData()[i].Lot;
                }
                else if (ColorMode_ == "PART")
                {
                    nColorNum = GanttDataSet_.GetGanttData()[i].Part;
                }
                else if (ColorMode_ == "PROCESS")
                {
                    nColorNum = GanttDataSet_.GetGanttData()[i].Part*10 + GanttDataSet_.GetGanttData()[i].Step;
                }
                else
                {
                    nColorNum = 0;
                }

                Brush brush = new System.Drawing.SolidBrush(System.Drawing.Color.White);
                //Operation
                if (GanttDataSet_.GetGanttData()[i].Type == "O")
                {
                    brush = new System.Drawing.SolidBrush( System.Drawing.Color.FromArgb( arrColor_[nColorNum % arrColor_.GetLength(0), 0], arrColor_[nColorNum % arrColor_.GetLength(0), 1], arrColor_[nColorNum % arrColor_.GetLength(0), 2]));
                    g.FillRectangle(brush, OperationRects_[i]);
                    g.DrawString(String.Format("{0}", GanttDataSet_.GetGanttData()[i].Content), f, Brushes.Black, OperationRects_[i], drawFormat);
                }
                //reentrance = retest
                else if (GanttDataSet_.GetGanttData()[i].Type == "R")
                {
                    brush = new System.Drawing.Drawing2D.HatchBrush(
                        System.Drawing.Drawing2D.HatchStyle.Percent70
                        , System.Drawing.Color.FromArgb(arrColor_[nColorNum % arrColor_.GetLength(0), 0], arrColor_[nColorNum % arrColor_.GetLength(0), 1], arrColor_[nColorNum % arrColor_.GetLength(0), 2])
                    );
                    g.FillRectangle(brush, OperationRects_[i]);
                    g.DrawString(String.Format("{0}", GanttDataSet_.GetGanttData()[i].Content), f, Brushes.Black, OperationRects_[i], drawFormat);
                }
                //preparation
                else if (GanttDataSet_.GetGanttData()[i].Type == "P")
                {
                    brush = new System.Drawing.Drawing2D.HatchBrush(System.Drawing.Drawing2D.HatchStyle.Percent60, System.Drawing.Color.LightGray);
                    g.FillRectangle(brush, OperationRects_[i]);
                    //g.DrawString(String.Format("{0}", GanttDataSet_.GetGanttData()[i].Content), f, Brushes.Black, OperationRects_[i], drawFormat);
                }
            }

            g.DrawRectangles(PenContent, OperationRects_);
            if (IndicateRect_.Count != 0)
            {
                Pen PenInd = new Pen(Color.SkyBlue, 5.0F);
                g.DrawRectangles(PenInd, IndicateRect_.ToArray());
            }


            //event
            for (int i = 0; i < GanttDataSet_.GetGanttData().Count; i++)
            {
                if (GanttDataSet_.GetGanttData()[i].Type == "E")
                {
                    Pen PenEvent = new Pen(Color.Red, 2.0F);
                    g.DrawLine(PenEvent, ChartAreaX_ + fWidthUnit * GanttDataSet_.GetGanttData()[i].End, ChartAreaY_, ChartAreaX_ + fWidthUnit * GanttDataSet_.GetGanttData()[i].End, ChartAreaY_ + ChartHeight_);
                    Font FontEventLabel = new Font("Arial", 10, FontStyle.Regular);
                    StringFormat FormatEventLabel = new StringFormat();
                    FormatEventLabel.Alignment = StringAlignment.Center;
                    FormatEventLabel.LineAlignment = StringAlignment.Far;
                    g.DrawString(GanttDataSet_.GetGanttData()[i].Content, FontEventLabel, Brushes.Red, ChartAreaX_ + fWidthUnit * GanttDataSet_.GetGanttData()[i].End, ChartAreaY_ - ChartAreaY_ * 0.05F, FormatEventLabel);
                }
            }
        }

        public void fitSizeToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Size = new System.Drawing.Size(this.ClientRectangle.Width, this.ClientRectangle.Height);
        }

        public void zoomInToolStripMenuItem_Click(object sender, EventArgs e)
        {
            int nWidth = this.Size.Width + (this.Size.Width / 10);
            int nHeight = this.Size.Height + (this.Size.Height / 10);
            this.Size = new System.Drawing.Size(nWidth, nHeight);
        }

        public void zoomOutToolStripMenuItem_Click(object sender, EventArgs e)
        {
            int nWidth = this.Size.Width - (this.Size.Width / 10);
            int nHeight = this.Size.Height - (this.Size.Height / 10);
            this.Size = new System.Drawing.Size(nWidth, nHeight);
        }

        private void UserControlGanttChartImage_MouseDown(object sender, MouseEventArgs e)
        {
            int nSameItem = 0;
            for (int i = 0; i < OperationRects_.Length; i++)
            {
                if (OperationRects_[i].Contains(e.X, e.Y))
                {
                    if (ColorMode_ == "LOT") nSameItem = GanttDataSet_.GetGanttData()[i].Lot;
                    else if (ColorMode_ == "PART") nSameItem = GanttDataSet_.GetGanttData()[i].Part;
                    else if (ColorMode_ == "PROCESS") nSameItem = GanttDataSet_.GetGanttData()[i].Part * 10 + GanttDataSet_.GetGanttData()[i].Step;
                    else nSameItem = 0;
                    break;
                }
            }

            for (int i = 0; i < OperationRects_.Length; i++)
            {
                if (ColorMode_ == "LOT")
                {
                    if (GanttDataSet_.GetGanttData()[i].Lot == nSameItem)
                        IndicateRect_.Add(OperationRects_[i]);
                }
                else if (ColorMode_ == "PART")
                {
                    if (GanttDataSet_.GetGanttData()[i].Part == nSameItem)
                        IndicateRect_.Add(OperationRects_[i]);
                }
                else if (ColorMode_ == "PROCESS")
                {
                    if (GanttDataSet_.GetGanttData()[i].Part * 10 + GanttDataSet_.GetGanttData()[i].Step == nSameItem)
                        IndicateRect_.Add(OperationRects_[i]);
                }
                else
                {
                    IndicateRect_.Add(OperationRects_[i]);
                }
            }

            this.Invalidate();
        }

        private void UserControlGanttChartImage_MouseUp(object sender, MouseEventArgs e)
        {
            IndicateRect_ = new List<RectangleF>();
            this.Invalidate();
        }
    }
}
