using CodeBlogFitness.BL.Model;
using System;
using System.Collections.Generic;
using System.Text;

namespace CodeBlogFitness.BL.Controller
{
    public class ExerciseController : BaseController
    {
        private readonly User user;
        public List<Exercise> Exercises { get; }
        public List<Activity> Activities { get; }
        private const string EXERCISES_FILE_NAME = "exercises.dat";
        private const string ACTIVITES_FILE_NAME = "activites.dat";

        public ExerciseController(User user)
        {
            this.user = user ?? throw new ArgumentNullException(nameof(user));
            Exercises = GetAllExercises();
            Activities = GetAllActivites();
        }

        public void Add(string activityName, DateTime begin, DateTime finish)
        {

        }

        private List<Exercise> GetAllExercises()
        {
            return Load<List<Exercise>>(EXERCISES_FILE_NAME) ?? new List<Exercise>();
        }

        private List<Activity> GetAllActivites()
        {
            return Load<List<Activity>>(ACTIVITES_FILE_NAME) ?? new List<Activity>();
        }

        private void Save()
        {
            Save(EXERCISES_FILE_NAME, Exercises);
            Save(ACTIVITES_FILE_NAME, Activities);
        }
    }
}
