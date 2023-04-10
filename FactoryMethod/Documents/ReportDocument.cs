using FactoryMethod.Pages;

namespace FactoryMethod.Documents {
    public sealed class ReportDocument : Document {

        protected override void CreatePages() {
            Pages.Add(new IntroductionPage());
            Pages.Add(new ResultsPage());
            Pages.Add(new ConclusionPage());
            Pages.Add(new SummaryPage());
            Pages.Add(new BibliographyPage());
        }
    }
}
