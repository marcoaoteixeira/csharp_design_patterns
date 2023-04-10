using FactoryMethod.Pages;

namespace FactoryMethod.Documents {
    public sealed class ResumeDocument : Document {

        protected override void CreatePages() {
            Pages.Add(new SkillsPage());
            Pages.Add(new EducationPage());
            Pages.Add(new ExperiencePage());
        }
    }
}
