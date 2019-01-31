
using Microcharts;
using MobileDataViewer.Models;
using MobileDataViewer.ViewModels;
using System.Collections.Generic;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;
using Entry = Microcharts.Entry;

namespace MobileDataViewer.Views
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class ItemDetailPage : ContentPage
    {
        private List<Entry> entries = new List<Entry>
        {
            new Entry(200)
            {
                Color = SkiaSharp.SKColor.Parse("#FF1493"),
                Label = "Январь",
                ValueLabel="200"
            },
            new Entry(400)
            {
                Color = SkiaSharp.SKColor.Parse("#FF1493"),
                Label = "Февраль",
                ValueLabel="400"
            },
            new Entry(200)
            {
                Color = SkiaSharp.SKColor.Parse("#FF1493"),
                Label = "Январь",
                ValueLabel="200"
            },
            new Entry(400)
            {
                Color = SkiaSharp.SKColor.Parse("#FF1493"),
                Label = "Февраль",
                ValueLabel="400"
            },
            new Entry(200)
            {
                Color = SkiaSharp.SKColor.Parse("#FF1493"),
                Label = "Январь",
                ValueLabel="200"
            },
            new Entry(400)
            {
                Color = SkiaSharp.SKColor.Parse("#FF1493"),
                Label = "Февраль",
                ValueLabel="400"
            },
            new Entry(200)
            {
                Color = SkiaSharp.SKColor.Parse("#FF1493"),
                Label = "Январь",
                ValueLabel="200"
            },
            new Entry(400)
            {
                Color = SkiaSharp.SKColor.Parse("#FF1493"),
                Label = "Февраль",
                ValueLabel="400"
            },
            new Entry(200)
            {
                Color = SkiaSharp.SKColor.Parse("#FF1493"),
                Label = "Январь",
                ValueLabel="200"
            },
            new Entry(400)
            {
                Color = SkiaSharp.SKColor.Parse("#FF1493"),
                Label = "Февраль",
                ValueLabel="400"
            },
            new Entry(-100)
            {
                Color = SkiaSharp.SKColor.Parse("#FF1493"),
                Label = "Март",
                ValueLabel="-100"
            }
        };
        private ItemDetailViewModel viewModel;

        public ItemDetailPage(ItemDetailViewModel viewModel)
        {
            InitializeComponent();

            BindingContext = this.viewModel = viewModel;

            Chart1.Chart = new BarChart() { Entries = entries };
        }

        public ItemDetailPage()
        {
            InitializeComponent();

            Item item = new Item
            {
                Text = "Item 1",
                Description = "This is an item description."
            };

            viewModel = new ItemDetailViewModel(item);
            BindingContext = viewModel;
        }
    }
}