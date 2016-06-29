namespace StudentImplementation
{
    using System;
    using System.Text;

    [Serializable]
    public class Student : ICloneable, IComparable<Student>
    {
        public Student(string firstName, string lastName, string socialSecurityNumber)
            : this(firstName, lastName, socialSecurityNumber, 0, 0)
        {
        }

        public Student(string firstName, string lastName, string socialSecurityNumber, Universities university, Faculties faculty)
            : this(firstName, lastName, socialSecurityNumber, null, university, faculty, 0)
        {
        }

        public Student(string firstName, string lastName, string socialSecurityNumber, string course, Universities university, Faculties faculty, Specialties specialty)
            : this(firstName, null, lastName, socialSecurityNumber, null, null, null, course, university, faculty, specialty)
        {
        }

        public Student(string firstName, string middleName, string lastName, string socialSecurityNumber, string permanentAddress, string phoneNumber, string email, string course, Universities university, Faculties faculty, Specialties specialty)
        {
            this.FirstName = firstName;
            this.MiddleName = middleName;
            this.LastName = lastName;
            this.SocialSecurityNumber = socialSecurityNumber;
            this.PermanentAddress = permanentAddress;
            this.PhoneNumber = phoneNumber;
            this.Email = email;
            this.Course = course;
            this.Specialty = specialty;
            this.University = university;
            this.Faculty = faculty;
        }

        public string FirstName { get; set; }
        public string MiddleName { get; set; }
        public string LastName { get; set; }
        public string SocialSecurityNumber { get; set; }
        public string PermanentAddress { get; set; }
        public string PhoneNumber { get; set; }
        public string Email { get; set; }
        public string Course { get; set; }
        public Universities University { get; set; }
        public Faculties Faculty { get; set; }
        public Specialties Specialty { get; set; }

        public override bool Equals(object obj)
        {
            Student temp = obj as Student;
            if ((object)temp == null)
                return false;
            return this.Equals(temp);
        }

        public bool Equals(Student value)
        {
            if (ReferenceEquals(null, value))
            {
                return false;
            }

            if (ReferenceEquals(this, value))
            {
                return true;
            }

            return Equals(this.FirstName, value.FirstName) &&
                   Equals(this.MiddleName, value.MiddleName) &&
                   Equals(this.LastName, value.LastName) &&
                   Equals(this.SocialSecurityNumber, value.SocialSecurityNumber) &&
                   Equals(this.PermanentAddress, value.PermanentAddress) &&
                   Equals(this.PhoneNumber, value.PhoneNumber) &&
                   Equals(this.Email, value.Email) &&
                   Equals(this.Course, value.Course) &&
                   this.University.Equals(value.University) &&
                   this.Faculty.Equals(value.Faculty) &&
                   this.Specialty.Equals(value.Specialty);
        }

        public override int GetHashCode()
        {
            unchecked
            {
                int result = 17;
                result = result * 23 + ((FirstName != null) ? this.FirstName.GetHashCode() : 0);
                result = result * 23 + ((MiddleName != null) ? this.MiddleName.GetHashCode() : 0);
                result = result * 23 + ((LastName != null) ? this.LastName.GetHashCode() : 0);
                result = result * 23 + ((SocialSecurityNumber != null) ? this.SocialSecurityNumber.GetHashCode() : 0);
                result = result * 23 + ((PermanentAddress != null) ? this.PermanentAddress.GetHashCode() : 0);
                result = result * 23 + ((PhoneNumber != null) ? this.PhoneNumber.GetHashCode() : 0);
                result = result * 23 + ((Email != null) ? this.Email.GetHashCode() : 0);
                result = result * 23 + ((Course != null) ? this.Course.GetHashCode() : 0);
                result = result * 23 + this.University.GetHashCode();
                result = result * 23 + this.Faculty.GetHashCode();
                result = result * 23 + this.Specialty.GetHashCode();
                return result;
            }
        }

        public static bool operator ==(Student a, Student b)
        {
            return Equals(a, b);
        }

        public static bool operator !=(Student a, Student b)
        {
            return !Equals(a, b);
        }

        object ICloneable.Clone()
        {
            return this.Clone();
        }

        public int CompareTo(Student other)
        {
            if (this.FirstName != other.FirstName)
            {
                return this.FirstName.CompareTo(other.FirstName);
            }

            if (this.MiddleName != other.MiddleName)
            {
                return this.MiddleName.CompareTo(other.MiddleName);
            }

            if (this.LastName != other.LastName)
            {
                return this.LastName.CompareTo(other.LastName);
            }

            if (this.SocialSecurityNumber != other.SocialSecurityNumber)
            {
                return int.Parse(this.SocialSecurityNumber) - int.Parse(other.SocialSecurityNumber);
            }

            return 0;
        }

        public override string ToString()
        {
            var studentInfo = new StringBuilder();
            var noInfoLabel = "Unknown";

            studentInfo.AppendLine("========== StudentInfo ==========");
            studentInfo.AppendLine(string.Format("FirstName: {0}", this.FirstName));
            studentInfo.AppendLine(string.Format("MiddleName: {0}", this.MiddleName ?? noInfoLabel));
            studentInfo.AppendLine(string.Format("LastName: {0}", this.LastName));
            studentInfo.AppendLine(string.Format("SSN: {0}", this.SocialSecurityNumber));
            studentInfo.AppendLine(string.Format("PermanentAddress: {0}", this.PermanentAddress ?? noInfoLabel));
            studentInfo.AppendLine(string.Format("PhoneNumber: {0}", this.PhoneNumber ?? noInfoLabel));
            studentInfo.AppendLine(string.Format("Email: {0}", this.Email ?? noInfoLabel));
            studentInfo.AppendLine(string.Format("University: {0}", this.University));
            studentInfo.AppendLine(string.Format("Faculty: {0}", this.Faculty));
            studentInfo.AppendLine(string.Format("Specialty: {0}", this.Specialty));
            studentInfo.AppendLine(string.Format("Course: {0}", this.Course ?? noInfoLabel));
            studentInfo.AppendLine("=================================");

            return studentInfo.ToString();
        }
    }
}