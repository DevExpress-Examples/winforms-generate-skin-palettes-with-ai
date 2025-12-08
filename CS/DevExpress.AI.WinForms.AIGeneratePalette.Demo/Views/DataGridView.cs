using DevExpress.XtraEditors;
using DevExpress.XtraGrid;
using DevExpress.AI.WinForms.AIGeneratePalette.Demo.Infrastructure;

namespace DevExpress.AI.WinForms.AIGeneratePalette.Demo.Views {
    public partial class DataGridView : XtraUserControl {
        DataGridView() {
            InitializeComponent();
        }
        public DataGridView(ICommonDataService dataService) : this() {
            DataService = dataService;
            customerBindingSource.DataSource = dataService.GetCustomers();
        }
        public ICommonDataService DataService { get; set; }

        void barButtonItem1_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e) {
            gridView1.ShowRibbonPrintPreview();
        }

        void barButtonItem2_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e) {
            gridView1.DeleteRow(gridView1.FocusedRowHandle);
        }
    }
}
