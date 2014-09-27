namespace LINQtoExcel
{
    using System;

    public class Student
    {
        private float bonus;
        private float attendances;
        private float teamworkScore;
        private int homeworkEvaluated;
        private int homeworkSent;
        private int examResult;
        private StudentTypes studentType;
        private Genders gender;
        private string email;
        private string lastName;
        private string firstName;
        private int id;
        private float result;

        public Student(
            int id,
            string firstName,
            string lastName,
            string email,
            Genders gender,
            StudentTypes studentType,
            int examResult,
            int homeworkSent,
            int homeworkEvaluated,
            float teamworkScore,
            float attendances,
            float bonus)
        {
            this.Id = id;
            this.FirstName = firstName;
            this.LastName = lastName;
            this.Email = email;
            this.Gender = gender;
            this.StudentType = studentType;
            this.ExamResult = examResult;
            this.HomeworkSent = homeworkSent;
            this.HomeworkEvaluated = homeworkEvaluated;
            this.TeamworkScore = teamworkScore;
            this.Attendances = attendances;
            this.Bonus = bonus;
            this.Result = CalculateResult();
        }

        public float Result
        {
            get
            {
                return this.result;
            }

            protected set
            {
                this.result = value;
            }
        }

        public int Id
        {
            get
            {
                return this.id;
            }

            set
            {
                this.id = value;
            }
        }

        public string FirstName
        {
            get
            {
                return this.firstName;
            }

            set
            {
                if (string.IsNullOrEmpty(value))
                {
                    throw new ArgumentNullException("FirstName", "FirstName can not be null or empty!");
                }

                this.firstName = value;
            }
        }

        public string LastName
        {
            get
            {
                return this.lastName;
            }

            set
            {
                if (string.IsNullOrEmpty(value))
                {
                    throw new ArgumentNullException("LastName", "LastName can not be null or empty!");
                }

                this.lastName = value;
            }
        }

        public string Email
        {
            get
            {
                return this.email;
            }

            set
            {
                if (string.IsNullOrEmpty(value))
                {
                    throw new ArgumentNullException("Email", "Email can not be null or empty!");
                }

                this.email = value;
            }
        }

        public Genders Gender
        {
            get
            {
                return this.gender;
            }

            set
            {
                this.gender = value;
            }
        }

        public StudentTypes StudentType
        {
            get
            {
                return this.studentType;
            }

            set
            {
                this.studentType = value;
            }
        }

        public int ExamResult
        {
            get
            {
                return this.examResult;
            }

            set
            {
                this.examResult = value;
            }
        }

        public int HomeworkSent
        {
            get
            {
                return this.homeworkSent;
            }

            set
            {
                this.homeworkSent = value;
            }
        }

        public int HomeworkEvaluated
        {
            get
            {
                return this.homeworkEvaluated;
            }

            set
            {
                this.homeworkEvaluated = value;
            }
        }

        public float TeamworkScore
        {
            get
            {
                return this.teamworkScore;
            }

            set
            {
                this.teamworkScore = value;
            }
        }

        public float Attendances
        {
            get
            {
                return this.attendances;
            }

            set
            {
                this.attendances = value;
            }
        }

        public float Bonus
        {
            get
            {
                return this.bonus;
            }

            set
            {
                this.bonus = value;
            }
        }

        public virtual float CalculateResult()
        {
            return (this.ExamResult + this.HomeworkEvaluated + this.HomeworkSent + this.TeamworkScore + this.Attendances) / 5;
        }

        public override string ToString()
        {
            return string.Format(
                "{0}, {1}, {2}, {3}, {4}, {5}, {6}, {7}, {8}, {9}, {10}, {11}, {12}",
                this.Id,
                this.FirstName,
                this.LastName,
                this.Email,
                this.Gender,
                this.StudentType,
                this.ExamResult,
                this.HomeworkSent,
                this.HomeworkEvaluated,
                this.TeamworkScore,
                this.Attendances,
                this.Bonus,
                this.CalculateResult());
        }
    }
}