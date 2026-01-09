using CommunityToolkit.Mvvm.ComponentModel;
using System.Collections.ObjectModel;
using PrositeCM.Models;

namespace PrositeCM.ViewModels
{
    public partial class ProjectSelectionViewModel : ObservableObject
    {
        private ObservableCollection<Project> _projects = new();
        private string _currentUser = "admin";
        private string _currentEmail = "admin@prosite.com";

        public ObservableCollection<Project> Projects
        {
            get => _projects;
            set => SetProperty(ref _projects, value);
        }

        public string CurrentUser
        {
            get => _currentUser;
            set => SetProperty(ref _currentUser, value);
        }

        public string CurrentEmail
        {
            get => _currentEmail;
            set => SetProperty(ref _currentEmail, value);
        }

        public ProjectSelectionViewModel()
        {
            LoadProjects();
        }

        private void LoadProjects()
        {
            // The 'required' keyword in Project.cs allows this clean initialization
            Projects.Add(new Project { Name = "Test Project 1", Role = "Owner", Description = "Initial testing phase" });
            Projects.Add(new Project { Name = "240 - Park Outlook", Role = "Owner", Description = "Residential complex" });
            Projects.Add(new Project { Name = "TB Building 5", Role = "Owner", Description = "Commercial refit" });
            Projects.Add(new Project { Name = "Durham Summit", Role = "Owner", Description = "Main structure" });
            Projects.Add(new Project { Name = "Durham Tech - Group 3", Role = "Owner", Description = "Educational wing" });
        }
    }
}