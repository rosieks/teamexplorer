namespace Rosieks.TeamFoundation.TeamExplorer.Markdown
{
    using Microsoft.TeamExplorerSample;
    using Microsoft.TeamFoundation.Controls;
    using Microsoft.TeamFoundation.VersionControl.Controls.Extensibility;

    [TeamExplorerSection(MarkdownCommentSection.SectionId, TeamExplorerPageIds.ChangesetDetails, 20)]
    public class MarkdownCommentSection : TeamExplorerBaseSection
    {
        internal const string SectionId = "D291B952-34D0-4CB3-BC4C-6121EA758526";

        private string comment;

        public MarkdownCommentSection()
        {
            this.Title = "Comment";
            this.IsExpanded = true;
            this.IsBusy = false;
            this.SectionContent = new MarkdownCommentSectionView();
            this.View.ParentSection = this;
        }

        public MarkdownCommentSectionView View
        {
            get
            {
                return (MarkdownCommentSectionView)this.SectionContent;
            }
        }

        public string Comment
        {
            get
            {
                if (this.comment == null)
                {
                    IPendingChangesExt pce = this.GetService<IPendingChangesExt>();
                    if (pce != null)
                    {
                        this.comment = pce.CheckinComment;
                    }
                }

                return this.comment;
            }
            private set
            {
                this.comment = value;
                this.RaisePropertyChanged("Comment");
            }
        }

        public override void Initialize(object sender, Microsoft.TeamFoundation.Controls.SectionInitializeEventArgs e)
        {
            base.Initialize(sender, e);

            IPendingChangesExt pce = this.GetService<IPendingChangesExt>();
            if (pce != null)
            {
                pce.PropertyChanged += this.PendingChangesChanged;
            }
        }

        private void PendingChangesChanged(object sender, System.ComponentModel.PropertyChangedEventArgs e)
        {
            if (e.PropertyName == "CheckinComment")
            {
                var pce = sender as IPendingChangesExt;
                this.Comment = pce.CheckinComment;
            }
        }
    }
}
