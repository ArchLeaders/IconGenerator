using ImageMagick;

string sourceFolder = Directory.GetCurrentDirectory();
string[] files = Directory.GetFiles(sourceFolder, "*.png", SearchOption.TopDirectoryOnly);

if (files.Length == 0) {
    return;
}

string output = Path.Combine(sourceFolder, "Icon.ico");

using (MagickImageCollection images = []) {
    images.AddRange(files.Select(x => new MagickImage(x)));
    images.Write(output);
}