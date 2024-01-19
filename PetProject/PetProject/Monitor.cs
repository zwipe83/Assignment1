using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PetProject
{
    internal class Monitor
    {
        private string? manufacturer;
        private string? modelName;
        private int horizontalResolutionInPixels;
        private int verticalResolutionInPixels;
        private int totalResolutionInPixels;
        private Color color;

        private void SaveManufacturer()
        {
            manufacturer = "";
        }
        private void SaveModel() 
        {
            modelName = "";
        }

        private void SaveHorizontalResolution()
        {
            horizontalResolutionInPixels = 0;
        }
        private void SaveVerticalResolution()
        {
            verticalResolutionInPixels = 0;
        }

        private void totalResolution()
        {
            totalResolutionInPixels = horizontalResolutionInPixels * verticalResolutionInPixels;
        }

        private void SaveColor()
        {
            color = Color.Black;
        }
    }
}
