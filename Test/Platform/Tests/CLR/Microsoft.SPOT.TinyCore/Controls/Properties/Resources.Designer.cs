//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Runtime Version:2.0.50727.3053
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace Controls.Properties
{
    
    internal partial class Resources
    {
        private static System.Resources.ResourceManager manager;
        internal static System.Resources.ResourceManager ResourceManager
        {
            get
            {
                if ((Resources.manager == null))
                {
                    Resources.manager = new System.Resources.ResourceManager("Controls.Properties.Resources", typeof(Resources).Assembly);
                }
                return Resources.manager;
            }
        }
        internal static Microsoft.SPOT.Bitmap GetBitmap(Resources.BitmapResources id)
        {
            return ((Microsoft.SPOT.Bitmap)(Microsoft.SPOT.ResourceUtility.GetObject(ResourceManager, id)));
        }
        internal static Microsoft.SPOT.Font GetFont(Resources.FontResources id)
        {
            return ((Microsoft.SPOT.Font)(Microsoft.SPOT.ResourceUtility.GetObject(ResourceManager, id)));
        }
        [System.SerializableAttribute()]
        internal enum BitmapResources : short
        {
            Green = -21438,
            Yellow = -16393,
        }
        [System.SerializableAttribute()]
        internal enum FontResources : short
        {
            small = 13070,
            NinaB = 18060,
        }
    }
}
