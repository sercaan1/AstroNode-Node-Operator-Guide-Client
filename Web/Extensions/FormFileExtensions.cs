namespace Web.Extensions
{
    public static class FormFileExtensions
    {
        public static async Task<string> GetAsBase64String(this IFormFile formFile)
        {
            await using var memoryStream = new MemoryStream();
            await formFile.CopyToAsync(memoryStream);
            byte[] imageBytes = memoryStream.ToArray();

            return Convert.ToBase64String(imageBytes);
        }
    }
}
