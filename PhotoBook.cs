using System;

namespace HelloWorld
{
    public class PhotoBook
    {
        public int _NumPages
        {
            get; set;
        }

        public PhotoBook(int _NumPages)
        {
            this._NumPages = _NumPages;
        }

        public int GetNumberPages()
        {
            return _NumPages;
        }

        public PhotoBook()
        {
            _NumPages = 16;
        }
    }
}
