


using AlbumDeFotos;

internal class Program
{
    private static void Main(string[] args)
    {
        AlbumFotos album = new AlbumFotos();
        album.GetNumeroPaginas();
        AlbumFotos album1 = new AlbumFotos(24);
        album1.GetNumeroPaginas();
        SuperAlbumFotos superAlbum = new SuperAlbumFotos(); 
        superAlbum.GetNumeroPaginas();
    }
}