using System;
using System.Collections;
using System.IO;
using System.Linq;
using System.Windows.Forms;
using System.Windows.Forms.DataVisualization.Charting;
using Common;
using DAL;
using LSExtensionControlLib;
using LSExtensionExplorer;
using LSSERVICEPROVIDERLib;
using Telerik.Charting;
using Telerik.WinControls.UI;
using Telerik.WinControls.UI.Export;

namespace StatusSdgByLab
{

    //[ComVisible(true)]
    //[ProgId("LSExtensionExpl.LSExtensionExplcls")]
    public partial class StatusSdgByLabcls : UserControl, ILSXplVisualControl
    {

        #region members
        private INautilusProcessXML nautilusProcessXML;

        private INautilusDBConnection ntlCon;

        /// <summary>
        ///     Id of the record selected
        /// </summary>
        private double recordID;

        /// <summary>
        ///     Service Provider object
        /// </summary>
        private LSSERVICEPROVIDERLib.NautilusServiceProvider serviceProvider;
        #endregion



        public StatusSdgByLabcls()
        {
            InitializeComponent();
        }

        public void PreDisplay()
        {
            //    radChartView1.LabelFormatting += radChartView1_LabelFormatting;
            ExceptionThrown += LSExtensionExpl_ExceptionThrown;
            //throw new NotImplementedException();
            Utils.CreateConstring(ntlCon);
            dal = new DataLayer();
            dal.Connect();
            var q=dal.GetTestTemplatesForPriceList();
            return;
            var labs = dal.GetLabs();
            ddlLabs.SelectedIndexChanged += ddlLabs_SelectedIndexChanged;
            ddlLabs.DisplayMember = "Name";
            ddlLabs.ValueMember = "LabInfoId";
            ddlLabs.DataSource = labs;

        }

        void ddlLabs_SelectedIndexChanged(object sender, Telerik.WinControls.UI.Data.PositionChangedEventArgs e)
        {
            label1.Text = ddlLabs.Text;
            if (ddlLabs.SelectedItem == null) return;
            this.radChartView1.Series.Clear();
            var lsb = ddlLabs.SelectedItem;
            long id = (long)lsb.Value;
            var sdgs = dal.GetSdgs().Where(s => s.LabInfoId == id);
            var group = sdgs.GroupBy(x => x.Status);
            // this.radChartView1.AreaType = ChartAreaType.Pie;
            if (rbBar.Checked)
            {
                this.radChartView1.AreaType = ChartAreaType.Cartesian;
                var series = new BarSeries();
                foreach (IGrouping<string, Sdg> grouping in group)
                {
                    //   var p = new PieDataPoint(grouping.Count(), grouping.Key);
                    var p = new CategoricalDataPoint(grouping.Count(), grouping.Key);

                    series.DataPoints.Add(p);

                }
                this.radChartView1.Series.Add(series);

            }
            else
            {
                this.radChartView1.AreaType = ChartAreaType.Pie;
                var series = new PieSeries();
                foreach (IGrouping<string, Sdg> grouping in group)
                {
                    //   var p = new PieDataPoint(grouping.Count(), grouping.Key);
                    var p = new PieDataPoint(grouping.Count(), grouping.Key);

                    series.DataPoints.Add(p);

                } this.radChartView1.Series.Add(series);
            }





            radChartView1.ShowLegend = true;



        }

        void radChartView1_LabelFormatting(object sender, ChartViewLabelFormattingEventArgs e)
        {
            PieDataPoint dataPoint = (PieDataPoint)e.LabelElement.DataPoint;
            e.LabelElement.Text = dataPoint.Value.ToString();
        }
        private IDataLayer dal;

        void LSExtensionExpl_ExceptionThrown(object sender, Exception e)
        {
            MessageBox.Show("Error");
        }

        public void ChangeDataExplorerView(DataExplorerViewStyles style)
        {
            //throw new NotImplementedException();
        }

        public string GetObjectsStaticItemText()
        {
            //throw new NotImplementedException();
            return "12";
        }

        public void BeforeFocusedNodeChange(string keyData)
        {
            //throw new NotImplementedException();
        }

        public void FocusedNodeChanged(string keyData)
        {
            //   var id = keyData.Split('/')[0];
            //    var c = dal.GetClientByID(long.Parse(id));
            //   label1.Text += "/n" + c.Name;
        }

        public void NeedRefresh(string keyData, params string[] parameters)
        {
            //throw new NotImplementedException();
        }

        public void ProcessToolbarItemClick(ToolbarItem item)
        {
            //throw new NotImplementedException();
        }

        public void DataExplorerToolbarButtonClicked(ToolbarItem item)
        {
            //throw new NotImplementedException();
        }
        private IExtensionControlSite site;
        public void SetServiceProvider(object sp)
        {

            if (sp != null)
            {
                // Cast the object to the correct type
                serviceProvider = (NautilusServiceProvider)sp;

                // Using the service provider object get the XML Processor interface
                // We will use this object to get information from the database
                nautilusProcessXML = Utils.GetXmlProcessor(serviceProvider);


                ntlCon = Utils.GetNtlsCon(serviceProvider);
            }

        }

        public void InitializeToolbarItemsStatus(ref Hashtable toolbarItems)
        {
            //throw new NotImplementedException();
        }

        public event ExceptionThrownEventHandler ExceptionThrown;

        private void button1_Click(object sender, EventArgs e)
        {

        }

        private void ddlLabs_SelectedIndexChanged_1(object sender, Telerik.WinControls.UI.Data.PositionChangedEventArgs e)
        {
            
        }

        private void button1_Click_1(object sender, EventArgs e)
        {
           // radChartView1.Serie
//            Telerik.WinControls.ra
////            ExportToPDF exporter = new ExportToPDF(0)
//            ExportToExcelMLImage a;//
//            //(radChartView1, stream);           
//            PivotExportToExcelML exporter;
//            //= new PivotExportToExcelML(this.radChartView1);
       }
    }
}