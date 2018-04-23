using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Animation;
using System.Windows.Shapes;
using System.Collections.ObjectModel;

namespace Implement_the_New_Item_Row_Feature {
    public partial class MainPage : UserControl {
        ObservableCollection<TestData> list;
        public MainPage() {
            InitializeComponent();
            #region Fill the GridControl with data
            list = new ObservableCollection<TestData>();
            for(int i = 0; i < 5; i++) {
                list.Add(new TestData()
                {
                    Text1 = Guid.NewGuid().ToString(),
                    Text2 = "text2 " + i,
                    Text3 = "text3 " + i
                });
            }
            grid.DataSource = list;
            #endregion
        }
    }
    #region Test data
    public class TestData {
        public string Text1 { get; set; }
        public string Text2 { get; set; }
        public string Text3 { get; set; }
    }
    #endregion
}
