using System;

namespace HelloWorld
{
    public class BigPhotoBook : PhotoBook
    {
        public void BigPhotoBookAlbum(int _NumPages)
        {
            this._NumPages = _NumPages;
        }

        public BigPhotoBook()
        {
            _NumPages = 64;
        }
    }
}
