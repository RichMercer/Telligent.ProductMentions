using System;
using System.Collections.Generic;
using Telligent.Evolution.Extensibility;
using Telligent.Evolution.Extensibility.Api.Version1;
using Telligent.Evolution.Extensibility.Content.Version1;
using Telligent.ProductMentions;

namespace Mentions
{
    public class ProductContent : IMentionableContentType, IContent
    {
        #region IPlugin Members

        public string Name => "Product Mentionable";

        public string Description => "Allows products to be mentioned in content.";

        public void Initialize() { }

        #endregion

        #region IMentionableContentType Members

        public Guid[] ApplicationTypes => new[] { Constants.ApplicationTypeId };

        public string ContentTypeName => Constants.ContentTypeName;

        public void AttachChangeEvents(IContentStateChanges stateChanges) { }

        public IContent Get(Guid contentId)
        {
            return ProductService.Get(contentId);
        }

        public IEnumerable<IContent> GetMentionables(int userId, string queryText, IMentionableFilter filter)
        {
            return ProductService.FindProduct(queryText);
        }

        public string GetMentionPreviewHtml(int userId, Guid contentId)
        {
            var content = Get(contentId) as ProductContent;
            if (content == null)
                return "Product could not be found";

            return content.Title;
        }

        public string GetMentionViewHtml(int userId, Guid contentId)
        {
            // TODO: You can add more HTML here to show an excerpt of the description etc.
            var content = Get(contentId) as ProductContent;
            if (content == null)
                return "Product could not be found";

            return $"<a href=\"{content.Url}\" target=\"_blank\">{content.Title}</a>";
        }

        #endregion

        #region IContent Members

        public string Title { get; set; }

        public string Body { get; set; }

        public string HtmlName(string target)
        {
            return Title;
        }

        public string HtmlDescription(string target)
        {
            return Body;
        }

        public Guid ContentId { get; set; }

        public Guid ContentTypeId => Constants.ContentTypeId;

        public int? CreatedByUserId { get; set; }

        public DateTime CreatedDate => DateTime.UtcNow;

        public string Url { get; set; }

        public string AvatarUrl { get; set; }

        public IApplication Application => Apis.Get<IGroups>().Root;

        public bool IsEnabled => true;

        #endregion
    }
}
