using System;

namespace tp_7_ejr_2
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Clear();
int publico=0, privado=0, cantidad=0;
            string escuela="1";
            float porcentajepub=0f;
            float porcentajepri=0f;


            Console.WriteLine("A continuacion ingrese a que clase de colegio asisiten los alumnos");

            while (escuela=="1" || escuela=="2"){
                Console.WriteLine("Ingrese 1 para alumno publico; ingrese 2 para privado, x salir");
                escuela=Console.ReadLine();
                Console.Clear();

                if(escuela =="1" ){
                        cantidad=cantidad+1;
                        publico=publico+1;
                }
                if(escuela== "2"){

                    cantidad=cantidad+1;
                    privado=privado+1;

                }
                if(escuela=="x"){
                    Console.WriteLine("Saliste");
                    Console.ReadKey();
                    escuela="salir";
                } 
                else if(escuela=="salir"){
                    Console.WriteLine("Debe ingresar una opcion validad: 1, 2 , x");
                    Console.WriteLine("Ingrese 1 para alumno publico; ingrese 2 para privado, x salir");
                    escuela=Console.ReadLine();

                }


            }
            Console.Clear();
            Console.WriteLine ("Presione una tecla para continuar");
            porcentajepri=(privado*100)/cantidad;
            porcentajepub=(publico*100)/cantidad;

            
            
            Console.WriteLine("La cantidad de alumnos Privados son {0}", privado);
            Console.WriteLine("La cantidad de Publicos son {0}", publico);
            Console.WriteLine("Porcentaje de Publicos son {0}%", porcentajepub);
            Console.WriteLine("Porcentaje de Privados son {0}%", porcentajepri);


        }
    }
}

        
    
