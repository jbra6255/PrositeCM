using CommunityToolkit.Mvvm.ComponentModel;
using System.Collections.ObjectModel;
using PrositeCM.Models;

namespace PrositeCM.ViewModels
{

    public partial class ProjectSelectionViewModel : ObservableObject
    {

        [ObservableProperty]
        private ObservableCollection<Project> _projects;

        [ObservableProperty]
        private string _currentUser = "admin";

        [ObservableProperty]
        private string _currentEmail = "admin@prosite.com";

        public ProjectSelectionViewModel()
        {
            Projects = new ObservableCollection<Project>();
            LoadProjects();
        }

        private void LoadProjects()
        {
            Projects.Add(new Project { Name = "Test Project 1", Role = "Owner", Description = "Initial testing phase" });
            Projects.Add(new Project { Name = "240 - Park Outlook", Role = "Owner", Description = "Residential complex" });
            Projects.Add(new Project { Name = "TB Building 5", Role = "Owner", Description = "Commercial refit" });
            Projects.Add(new Project { Name = "Durham Summit", Role = "Owner", Description = "Main structure" });
            Projects.Add(new Project { Name = "Durham Tech - Group 3", Role = "Owner", Description = "Educational wing" });
        }
    }
}