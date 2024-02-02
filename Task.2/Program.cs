

using Task._2;

var photo = new PhotoBook();
System.Console.WriteLine(photo.GetNumberPages());

var testPhoto = new PhotoBookTest(24);
System.Console.WriteLine(testPhoto.GetNumberPages());

var bigPhoto = new BigPhotoBook();
System.Console.WriteLine(bigPhoto.GetNumberPages()); 