using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace App5
{
	[XamlCompilation(XamlCompilationOptions.Compile)]
	public partial class BmiResult : ContentPage
	{
        private float height;

        // 引数のないコンストラクタ
        public BmiResult ()
		{
			InitializeComponent ();
            buttonBack.Clicked += buttonBackClicked;
        }

        // 引数のあるコンストラクタ
        public BmiResult(float height)
        {
            InitializeComponent();
            this.height = height;
            labelBMI.Text = "Height=" + height;
            buttonBack.Clicked += buttonBackClicked;
        }

        // 前のページに戻るボタンの処理
        private void buttonBackClicked(object sender, EventArgs e)
        {
            Navigation.PopModalAsync();
        }
    }
}