using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;

namespace TestFlexLayout
{
	public partial class MainPage : ContentPage
	{
        List<Category> ListCategory;
        int f = 25;
        public MainPage()
		{            
            InitializeComponent(); 
            ListCategory = new List<Category>
            {
                new Category{Code="0000",Image="gallery.png", NameAr="Name Arabic Arabic ArabicArabic",NameEn="Name En",ShortNameAr="ShortAr",ShortNameEn="ShortEn"},
                new Category{Code="0000",Image="gallery.png", NameAr="Name Arabic",NameEn="Name En",ShortNameAr="ShortAr",ShortNameEn="ShortEn"},
                new Category{Code="0000",Image="gallery.png", NameAr="Name Arabic",NameEn="Name En",ShortNameAr="ShortAr",ShortNameEn="ShortEn"}
            };
            ListCategorie.ItemsSource = ListCategory;
            this.SizeChanged += OnSizeChanged;
            
            //L5.VerticalOptions = LayoutOptions.Center;

        }       

        void OnSizeChanged(object sender, EventArgs e)
        {

            Debug.WriteLine(this.Width +" "+ this.Height);

            //if (this.Width / 100 > 10)
            //{
            //    L1.FontSize = this.Width / 100;
            //    L2.FontSize = this.Width / 100;
            //    L3.FontSize = this.Width / 100;
            //    L4.FontSize = this.Width / 100;
            //    L5.FontSize = this.Width / 100;

            //}
            //else
            //{
            //    L1.FontSize = 13;
            //    L2.FontSize = 13;
            //    L3.FontSize = 13;
            //    L4.FontSize = 13;
            //    L5.FontSize = 13;
            //}            
            //Debug.WriteLine("width " + L5.Width);
            //if (L5.Width > 0)
            //{
            //    st1.HeightRequest = L5.Width - 40;
            //}

        }
    }
}
