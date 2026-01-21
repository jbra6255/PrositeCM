using CommunityToolkit.Mvvm.ComponentModel;
using System.Collections.ObjectModel;
using PrositeCM.Models; // Ensure this matches your Model namespace (Capital 'S')
using Microsoft.EntityFrameworkCore; // Required for .Include()
using System.Linq;

namespace PrositeCM.ViewModels
{
    public partial class ProjectSelectionViewModel : ObservableObject
    {
        private ObservableCollection<Project> _projects = new();

        // You can keep these for now to display in the UI corner
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

        public void LoadProjects()
        {
            Projects.Clear();

            // Connect to the database
            using (var db = new PrositeDbContext())
            {
                // Safety check: Creates the db file if it doesn't exist yet
                db.Database.EnsureCreated();

                // 3. Fetch projects from DB
                // Using .Include(p => p.Owner) so we can display the owner's name if needed
                var dbProjects = db.Projects
                                   .Include(p => p.Owner)
                                   .ToList();

                // Add them to the ObservableCollection so the UI updates
                foreach (var project in dbProjects)
                {
                    Projects.Add(project);
                }
            }
        }
    }
}