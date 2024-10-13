namespace Portfolio_Services.Services.impl
{
    public class ContentService : IContentService
    {
        string IContentService.getDummyText()
        {
            return "This is some text";
        }
    }
}
