namespace System.Windows
{
    internal class SizeChangedEventHandler
    {
        private Action<object, EventArgs> mainWindow_Resize;

        public SizeChangedEventHandler(Action<object, EventArgs> mainWindow_Resize)
        {
            this.mainWindow_Resize = mainWindow_Resize;
        }
    }
}