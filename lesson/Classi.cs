
namespace lesson
{
    public class Student: ClassMember
    {
        public string Name
        {
            get
            {
                return this.name;
            }
        }

        private string name;

        public Student(string Name)
        {
            if (String.IsNullOrWhiteSpace(Name))
            {
                throw new ArgumentNullException("Il nome non può essere vuoto");
            }
            
            this.name = Name;
        }
    }

    public class  Teacher: ClassMember
    {
        public string Name
        {
            get
            {
                return this.name;
            }
        }

        private string name;

        public string Title
        {
            get
            {
                return this.role;
            }
        }

        private string role;

        public Teacher(string Name, string Role)
        {
            if (String.IsNullOrWhiteSpace(Name))
            {
                throw new ArgumentNullException("Il nome non può essere vuoto");
            }
            else if (String.IsNullOrWhiteSpace(Role))
            {
                throw new ArgumentNullException("Il ruolo non può essere vuoto");
            }

            
            this.name = Name;
            this.role = Role;
        }
    }

    public class Class
    {
        public string Course
        {
            get
            {
                return this.course;
            }
        }
        
        private string course;

        public ClassMember[] Members
        {
            get
            {
                return this.members;
            }
        }

        private ClassMember[] members;

        public Class(string course, ClassMember[] members)
        {
            if(!String.IsNullOrWhiteSpace(course)) 
            {
                throw new ArgumentException("Il nome del corso non può essere vuoto");
            }
            else if(members.Length == 0 || members == null)
            {
                throw new ArgumentException("Il vettore membri non può essere vuoto");
            }
                this.course = course;
            this.members = members;
        }
    }



    
}
