namespace Rosieks.TeamFoundation.TeamExplorer.Markdown
{
    using System.Windows;
    using System.Windows.Controls;

    /// <summary>
    /// Interaction logic for MarkdownCommentSectionView.xaml
    /// </summary>
    public partial class MarkdownCommentSectionView : UserControl
    {
        public MarkdownCommentSectionView()
        {
            this.InitializeComponent();
        }

        public MarkdownCommentSection ParentSection
        {
            get 
            {
                return (MarkdownCommentSection)GetValue(ParentSectionProperty);
            }

            set
            {
                SetValue(ParentSectionProperty, value);
            }
        }

        public static readonly DependencyProperty ParentSectionProperty = 
            DependencyProperty.Register("ParentSection", typeof(MarkdownCommentSection), typeof(MarkdownCommentSectionView));
    }
}
