using CookBook.Services;
using Microsoft.Extensions.DependencyInjection;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CookBook.UI
{
    public partial class FoodManagerForm : Form
    {
        private readonly IServiceProvider _serviceProvider;
        public FoodManagerForm(IServiceProvider serviceProvider)
        {
            InitializeComponent();

            _serviceProvider = serviceProvider;

            FoodManagerCache foodManagerCache = _serviceProvider.GetRequiredService<FoodManagerCache>();

            foodManagerCache.RefreshData();
        }

       
    }
}
