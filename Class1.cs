using System;


namespace UsuarioLibrary
{
    public class Usuario
    {
        #region Atributos
        private string nombre;
        private string password;
        #endregion

        #region Propiedades
        public string Nombre {
            get => nombre;
            set
            {
                if( value == "")
                {
                    nombre = "Anonymous";
                }
                else
                {
                    nombre = value;

                }
            }
 
        }
        public string Password {
            get => password;
            set
            {
                if( value == "")
                {
                    password = GenerateRandPassword(15);
                }
                else
                {
                    password = value;
                }

                
            } 
        }
        #endregion

        #region Métodos

        private string GenerateRandPassword(int longPass)
        {
            Random random = new Random();
            string password = "";

            for(int i=0; i< longPass; i++)
            {
                password += (char)random.Next(255);


            }
            return password;

        }

        #endregion

        #region Constructores
        public Usuario(string nombre, string password)
        {
            Nombre = nombre;
            Password = password;
        }
        #endregion
    }
}
