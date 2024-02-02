using System.Diagnostics;

namespace Task._2;

public class PhotoBook
{
    private int _numPages;

    public PhotoBook() : this(16) { }

    public PhotoBook(int numPages)
    {
        _numPages = numPages;
    }
   public int GetNumberPages()
   {
    return _numPages;
   }

}
