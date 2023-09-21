namespace Eshop.Domain.core.Dtos.Pictures;
    public class PictureAddDto
    {
        public string PictureLinkAddress { get; set; }

        public int? CategoryId { get; set; }

         public int? ProductId { get; set; }
}

