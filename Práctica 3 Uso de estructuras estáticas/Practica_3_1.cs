// Este programa implementa una agenda básica de contactos con opciones para agregar,
// borrar, buscar y ordenar contactos.using System;
using System;

public class Practica_3_1
{
    // Estructura para almacenar una fecha de nacimiento
    struct FechaNacimiento
    {
        public int dia;
        public int mes;
        public int anio;
    }
    // Estructura para almacenar la información de un contacto
    struct Contacto
    {
        public string nombreCompleto;
        public string direccion;
        public string telefono;
        public string ciudad;
        public FechaNacimiento fechaNacimiento;
    }
    
    static void Main()
    {
        // Agenda con capacidad para 50 contactos (segun indicado)
        Contacto[] agenda = new Contacto[50];
        int opcion, contador = 0, mostrarContactos = 0;
        
        do
        {
            //Menu principal del programa
            Console.WriteLine("\n===== AGENDA DE CONTACTOS =====");
            Console.WriteLine("1. Añadir contacto.");
            Console.WriteLine("2. Borrar contacto.");
            Console.WriteLine("3. Mostrar contactos de una ciudad.");
            Console.WriteLine("4. Mostrar contactos por un año");
            Console.WriteLine("5. Mostrar contactos por nombre.");
            Console.WriteLine("0. Salir");
            Console.Write("Elige una opción: ");
            opcion = Convert.ToInt32(Console.ReadLine());

            switch (opcion)
            {
                //Añadir contacto
                case 1:
                    Contacto nuevo;
                    FechaNacimiento fechaNacimiento;
                    
                    //Inicializamos la fecha
                    fechaNacimiento.dia = 0;
                    fechaNacimiento.mes = 0;
                    fechaNacimiento.anio = 0;
                    
                    //Pedimos datos
                    Console.WriteLine("=== AÑADIR CONTACTOS ===");
                    Console.Write("Introduzca el nombre completo: ");
                    nuevo.nombreCompleto = Console.ReadLine();
                    Console.Write("Introduzca el direccion: ");
                    nuevo.direccion = Console.ReadLine();
                    Console.Write("Introduzca el telefono: ");
                    nuevo.telefono = Console.ReadLine();
                    Console.Write("Introduzca el ciudad: ");
                    nuevo.ciudad = Console.ReadLine();
                    
                    //Introduccion de la fehca en formato
                    Console.Write("Introduzca la fecha de nacimiento (dd/mm/aaaa): ");
                    String fechaNac = Console.ReadLine();
                    String[] split = fechaNac.Split('/');
                    
                    //Convertimos la fecha
                    fechaNacimiento.dia = Convert.ToInt32(split[0]);
                    fechaNacimiento.mes = Convert.ToInt32(split[1]);
                    fechaNacimiento.anio = Convert.ToInt32(split[2]);
                    nuevo.fechaNacimiento = fechaNacimiento;
                    
                    //Comprobamos el espacio en los contatos
                    if(contador < agenda.Length)
                    {
                        agenda[contador] = nuevo;
                        contador++;
                        Console.WriteLine("\nContacto añadido con exito.");
                    } else 
                    {
                        Console.WriteLine("ERROR: Se ha alcanzado la " + "capacidad maxima de la agenda.");
                    }
                    
                    break;
                
                //Borrar contacto
                case 2:

                    if (contador > 0)
                    {
                        //Mostramos todos los contactos de la agenda
                        for (int i = 0; i < contador; i++)
                        {
                            Console.WriteLine(i + 1 + " Nombre: " + agenda[i].nombreCompleto +
                                              ", Direccion: " + agenda[i].direccion +
                                              ", Telefono: " + agenda[i].telefono +
                                              ", Ciudad: " + agenda[i].ciudad + 
                                              ", Fecha de Nacimiento: {0}/{1}/{2}"
                                , agenda[i].fechaNacimiento.dia
                                , agenda[i].fechaNacimiento.mes
                                , agenda[i].fechaNacimiento.anio);
                        }
                        
                        Console.WriteLine("Selecciona el contacto a borrar: ");
                        int num = Convert.ToInt32(Console.ReadLine());

                        if ((num - 1) >= 0 && (num - 1) < contador)
                        {
                            //Desplazamos los contacots para rellenar hueco
                            for (int i = num - 1; i < contador - 1; i++)
                            {
                                agenda[i] = agenda[i+1];
                            }
                            contador--;
                            Console.WriteLine("Eliminando contacto...");
                            Console.WriteLine("Contacto elimnado con exito.");
                        }
                    }
                    else
                    {
                        Console.WriteLine("No existen contactos.");
                    }
                    break;

                //Mostrar contactos de una ciudad
                case 3:
                    Console.WriteLine("Ingresa la ciudad: ");
                    String nombreCiudad = Console.ReadLine();
                    for(int i = 0; i < contador; i++)
                    {
                        //Pasamos lo que nos indica el usuario y lo pasamos a minisculas
                        if (nombreCiudad.ToLower().Equals(agenda[i].ciudad.ToLower()))
                        {
                            Console.WriteLine(i + 1 + " Nombre: " + agenda[i].nombreCompleto +
                                              ", Direccion: " + agenda[i].direccion +
                                              ", Telefono: " + agenda[i].telefono +
                                              ", Ciudad: " + agenda[i].ciudad + 
                                              ", Fecha de Nacimiento: {0}/{1}/{2}"
                                , agenda[i].fechaNacimiento.dia
                                , agenda[i].fechaNacimiento.mes
                                , agenda[i].fechaNacimiento.anio);
                            
                            mostrarContactos++;
                        }
                    }
                    
                    if (mostrarContactos == 0)
                    {
                        Console.WriteLine("No existen contactos de esa ciudad.");
                    }
                    mostrarContactos = 0;
                    break;
                
                //Mostrar contactos por año
                case 4:
                    Console.WriteLine("Ingresa un año de nacimiento: ");
                    int anyoNacimiento = Convert.ToInt32(Console.ReadLine());
                    for(int i = 0; i < contador; i++)
                    {
                        if (anyoNacimiento == agenda[i].fechaNacimiento.anio)
                        {
                            Console.WriteLine(i+1 
                                               + "º: Nombre: " + agenda[i].nombreCompleto 
                                               + ", Direccion: " + agenda[i].direccion
                                               + ", Telefono: " + agenda[i].telefono
                                               + ", Ciudad: " + agenda[i].ciudad
                                               + ", Fecha de nacimiento: {0}/{1}/{2}"
                                , agenda[i].fechaNacimiento.dia
                                , agenda[i].fechaNacimiento.mes
                                , agenda[i].fechaNacimiento.anio);
                            
                            contador++;
                        }
                    }
                    
                    if (contador == 0)
                    {
                        Console.WriteLine("No se encontraron contactos de ese año.");
                    }
                    mostrarContactos = 0;
                    break;
                //Ordenar array por nombre
                case 5: 
                    //Ordenar nombre
                    for (int i = 0; i < contador - 1; i++)
                    {
                        for (int j = i + 1; j < contador; j++)
                        {
                            if (agenda[i].nombreCompleto.CompareTo(agenda[j].nombreCompleto) > 0)
                            {
                                Contacto temp = agenda[i]; 
                                agenda[i] = agenda[j];
                                agenda[j] = temp;
                            }
                        }
                    }
                    
                    Console.WriteLine("Contactos ordenados: ");
                    for(int i = 0; i < contador; i++)
                    {
                        Console.WriteLine((i+1) + "º: Nombre: " + agenda[i].nombreCompleto 
                                          + ", Direccion: " + agenda[i].direccion
                                          + ", Telefono: " + agenda[i].telefono
                                          + ", Ciudad: " + agenda[i].ciudad
                                          + ", Fecha de nacimiento: {0}/{1}/{2}"
                            , agenda[i].fechaNacimiento.dia
                            , agenda[i].fechaNacimiento.mes
                            , agenda[i].fechaNacimiento.anio);
                    }
                    break;

                case 0:
                    Console.WriteLine("Saliendo...");
                    break;

                default:
                    Console.WriteLine("Opción no válida.");
                    break;
            }

        } while (opcion != 0);
    }
}

