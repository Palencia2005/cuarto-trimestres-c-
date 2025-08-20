// // See https://aka.ms/new-console-template for more information
Console.WriteLine("Hello, World!");

// // programacion estructurada
// // ejemplo de manejo de variables


// //sintaxis de variables
// // tipo nombreVariable = valor;
// // tipos de datos primitivos
// int edad = 30; // entero
// char inicial = 'J'; // caracter
// string nombre = "Juan"; // cadena de texto

// //tipos de datos fechas
// DateTime fechaNacimiento = new DateTime(1993, 5, 15); // fecha y hora
// dateOnly fechaActual = DateOnly.FromDateTime(DateTime.Now); // solo fecha
// //booleano
// bool esEstudiante = true; // falso o true

// // tipos de datos numericos
// float altura = 1.75f; // numero con decimales
// double peso = 70.5; // numero con decimales de doble precision
// //decimal para dinero
// decimal salario = 1500.50m; // numero con decimales de alta precision

// //tipos de datos completos
// objeto persona = { nombre: "Juan", edad = 30 };

// //operaciones de variables
// int suma = edad + 5; // suma
// console.WriteLine($"Suma: {suma}"); // imprime la suma

// //sumar enteros
//  int numero1 = 10;
//  int numero2 = 20;
//     int resultadoSuma = numero1 + numero2; // suma de enteros
//     console.WriteLine($"Resultado de la suma: {resultadoSuma}"); // imprime el resultado

// // ejemplo de suma de dos numeros
// console.WriteLine("Numero uno:");
// int numeroA = convert.ToInt32(console.ReadLine());// convercion de tipo
// Console.WriteLine("Numero dos:");
// int numeroB = int.Parse(console.ReadLine()); // otra forma de conversión
// int resultado = numeroA + numeroB; // suma de los dos numeros
// Console.WriteLine($"El resultado de la suma es: {resultadoSumaResulatado}"); // imprime el resultado

// //conversiones de tipos

// //string edadComoString = edad.ToString(); // convertir entero a cadena



// //solicito datos de usuario como nombre, edad, altura y peso

// Console.WriteLine("Ingrese el nombre:");
// string nombre = Console.ReadLine();

// Console.WriteLine("Ingrese su edad:");
// int edad = Convert.ToInt32(Console.ReadLine());

// Console.WriteLine("Ingrese su altura en metros:");
// double altura = double.Parse(Console.ReadLine());

// Console.WriteLine("ingrese su peso:");
// double peso = double.Parse(Console.ReadLine());

//  // 2. Calcular el Índice de Masa Corporal
//  // Fórmula: IMC = peso / (estatura * estatura)

//  double imc = peso / (altura * altura);

//  // 3. Mostrar el resultado
// Console.WriteLine($"Hola {nombre}, tienes {edad} años, tu altura es {altura} metros y tu peso es {peso} kg.");
// Console.WriteLine($"Tu Índice de Masa Corporal (IMC) es: {imc:F2}");

//conversor de monedas
//  Console.WriteLine("\n--- Conversor de moneda ---");

//         Console.WriteLine("Ingrese su nombre:");
//         string nombre2 = Console.ReadLine();

//         Console.WriteLine("Ingrese la cantidad en pesos colombianos (COP):");
//         double cantidadCOP = double.Parse(Console.ReadLine());

//         // Tasas de cambio estimadas (puedes actualizarlas si deseas)
//         double tasaUSD = 0.00026; // Dólares estadounidenses
//         double tasaEUR = 0.00024; // Euros
//         double tasaMXN = 0.0045;  // Pesos mexicanos

//         // Calcular conversiones
//         double enDolares = cantidadCOP * tasaUSD;
//         double enEuros = cantidadCOP * tasaEUR;
//         double enPesosMex = cantidadCOP * tasaMXN;

//         // Mostrar resultados con formato
//         Console.WriteLine($"\n💰 Conversión de moneda para {nombre2}:");
//         Console.WriteLine($"- {cantidadCOP:N2} COP equivalen a:");
//         Console.WriteLine($"  🟢 {enDolares:N2} USD");
//         Console.WriteLine($"  🔵 {enEuros:N2} EUR");
//         Console.WriteLine($"  🟡 {enPesosMex:N2} MXN");

//         // Esperar que el usuario presione una tecla para cerrar
//         Console.WriteLine("\nPresione cualquier tecla para salir...");
//         Console.ReadKey();


// See https://aka.ms/new-console-template for more information
// Console.WriteLine("Ejemplo estructuras condicionales");


// Console.WriteLine("Estructura if");

//if simple
//sintaxis
// sbyte EDAD_PARAMETRO = 18;
// console.WriteLine("Ingrese su edad: ");
// sbyte edad = sbyte.parce(console.ReadLine());
// if (dato1 >= EDAD_PARAMETRO)
// {
//     Console.WriteLine("Eres adulto perr@");
// }



// //if compuesto

// if (true)
// {
//     Console.WriteLine("La condicion es verdadera");
// }
// else  (false)
// {
//     Console.WriteLine("La condicion es falsa");
// }

// //if anidado
// if (true)
// {
//     Console.WriteLine("La condicion es verdadera");
// }
// else
// {
//     if (false)
//     {
//         Console.WriteLine("La condicion es falsa");
//     }
//     else
//     {
//         Console.WriteLine("La condicion es falsa");
//     }
// }

//Hombre ideal
// Console.Write("Estado civil: ");
// string estadoCivil = Console.ReadLine();
// Console.Write("Edad: ");
// sbyte edad = sbyte.Parse(Console.ReadLine());
// Console.Write("Responsable: ");
// bool responsable = bool.Parse(Console.ReadLine());
// Console.Write("Hijos: ");
// string hijos = Console.ReadLine();

// string PARAMETRO_ESTADO_CIVIL = "soltero";
// sbyte PARAMETRO_EDAD = 20;
// bool PARAMETRO_RESPONSABLE = true;
// string PARAMETRO_HIJOS = "sin hijos";

// if(estadoCivil == PARAMETRO_ESTADO_CIVIL)
// {
//     if(edad >= PARAMETRO_EDAD)
//     {
//         if(responsable == PARAMETRO_RESPONSABLE)
//         {
//                 if(hijos != PARAMETRO_HIJOS)
//                 {
//                     Console.WriteLine("Eres el hombre ideal");
//                 }
//                 else
//                 {
//                     Console.WriteLine("No eres el hombre ideal, tienes hijos");
//                 }
//         }
//         else
//         {
//             Console.WriteLine("No eres el hombre ideal, no eres responsable");
//         }
//     }
//     else
//     {
//         Console.WriteLine("No eres el hombre ideal, no tienes la edad requerida");
//     }

// }else
// {
//     Console.WriteLine("No eres el hombre ideal, no eres soltero");
// }

//uso de operadores logicos
// if (estadoCivil == PARAMETRO_ESTADO_CIVIL && 
//     edad >= PARAMETRO_EDAD && 
//     responsable == PARAMETRO_RESPONSABLE && 
//     hijos != PARAMETRO_HIJOS)
// {
//     Console.WriteLine("Eres el hombre ideal");
// }
// else
// {
//     Console.WriteLine("No eres el hombre ideal");
// }

// //USO de operadores logicos
// if (estadoCivil == PARAMETRO_ESTADO_CIVIL || 
//     edad >= PARAMETRO_EDAD || 
//     responsable == PARAMETRO_RESPONSABLE || 
//     hijos != PARAMETRO_HIJOS)
// {
//     Console.WriteLine("Eres el hombre ideal");
// }
// else
// {
//     Console.WriteLine("No eres el hombre ideal");
// }

// for (int i = 1; i == 10; i++)
// {
//     Console.WriteLine("edad");
//     sbyte edad = sbyte.Parse(Console.ReadLine());
//     Console.WriteLine("Edad es:" + edad);
// }


// Ciclos:
// ciclosn for: Para cuando se sabe cuántas veces se va a repetir el ciclo.
// for (int i = 0; i <= 2; i += 2)
// {
//     Console.WriteLine("Edad");
//     sbyte edad = sbyte.Parse(Console.ReadLine());
//     Console.WriteLine("Edad es: " + edad);
// }
// ciclos while: Para cuando no se sabe cuántas veces se va a repetir el ciclo.
// Console.WriteLine("Edad");
// sbyte edad = sbyte.Parse(Console.ReadLine());
// sbyte edad_parametro_centinela = 99; // parametro centinela

// while (edad != edad_parametro_centinela)
// {
//     // cuando va hacer se va hacer lo que hay en bloque de codeigo 
//     Console.WriteLine("Puede ingresar");
//     edad = sbyte.Parse(Console.ReadLine());

//     Console.WriteLine("Edad es: ");
//     edad = sbyte.Parse(Console.ReadLine());
// }

// ciclos do while: Para cuando no se sabe cuántas veces se va a repetir el ciclo, pero al menos se debe ejecutar una vez.
// sbyte edad_parametro_centinela = 99;
// Console.WriteLine("Edad: ");
// sbyte edad = sbyte.Parse(Console.ReadLine());
// do
// {
//     Console.WriteLine("Edad es: ");
//     edad = sbyte.Parse(Console.ReadLine());
// } while (edad != edad_parametro_centinela);


// variable



// array 
// array - lista (string - numeros ) - diccionarios
// string[] nombres = { "Ana", "Maria", "Jose", "Adres" };
// foreach (var nombre in nombres)
// {
//     Console.WriteLine(nombres);
// }

// lista
// List<string> nombres = new List<string>() { "Ana", "Maria", "Jose", "Andres" };

// llenar lista
// nombres.Capacity;
// nombres.Add()
// nombres.Add("Ana");
// nombres.Add("Maria");
// nombres.Add("Jose"); 
// nombres.Add("Andres");

// foreach (string nombre in nombres)
// {
//     Console.WriteLine(nombre);
// }

// lista numerica
// List<int> anios = new List<int>();

// anios.Add(2001);
// anios.Add(2010);
// anios.Add(2020);
// anios.Add(2024);

// foreach (int anio in anios)
// {
//     Console.WriteLine($" {anio}");
// }

// diccionario (sintaxis)
// diccionario<tipo de datos key, value> nombre_dicionario = new Dictionary<string, int>(tipo de datos key , value);
// Dictionary<string, int> lista_productos = new Dictionary<string, int>()
// {
//    {"key" , "value"},
//    {"key" , "value"},
//    {"key" , "value"},
// };


// Dictionary<string, int> lista_productos = new Dictionary<string, int>()
// {
//    {"Manzana" , 100},
//    {"Pera" , 200},
//    {"Uva" , 300},
// };

// foreach (var producto in lista_productos)
// {
//    Console.WriteLine($"Producto: {producto.Key}, Precio: {producto.Value}");
// }


// ejemplo 1
// Dictionary<string, int> lista_productos = new Dictionary<string, int>()
// {
//     {"Manzana", 100},
//     {"Pera", 200},
//     {"Uva", 300},
// };

// bool salir = false;

// while (!salir)
// {
//     Console.WriteLine("\n--- Control de Stock ---");
//     Console.WriteLine("1. Ver inventario");
//     Console.WriteLine("2. Agregar producto");
//     Console.WriteLine("3. Retirar producto");
//     Console.WriteLine("4. Salir");
//     Console.Write("Seleccione una opción: ");

//     string opcion = Console.ReadLine();

//     switch (opcion)
//     {
//         case "1":
//             Console.WriteLine("\nInventario actual:");
//             foreach (var producto in lista_productos)
//             {
//                 Console.WriteLine($"Producto: {producto.Key}, Cantidad: {producto.Value}");
//             }
//             break;

//         case "2":
//             Console.Write("Nombre del producto a agregar: ");
//             string prodAgregar = Console.ReadLine();
//             Console.Write("Cantidad a agregar: ");
//             int cantidadAgregar = int.Parse(Console.ReadLine());

//             if (lista_productos.ContainsKey(prodAgregar))
//                 lista_productos[prodAgregar] += cantidadAgregar;
//             else
//                 lista_productos.Add(prodAgregar, cantidadAgregar);

//             Console.WriteLine("Producto agregado correctamente.");
//             break;

//         case "3":
//             Console.Write("Nombre del producto a retirar: ");
//             string prodRetirar = Console.ReadLine();
//             if (lista_productos.ContainsKey(prodRetirar))
//             {
//                 Console.Write("Cantidad a retirar: ");
//                 int cantidadRetirar = int.Parse(Console.ReadLine());
//                 if (lista_productos[prodRetirar] >= cantidadRetirar)
//                 {
//                     lista_productos[prodRetirar] -= cantidadRetirar;
//                     Console.WriteLine("Producto retirado correctamente.");
//                 }
//                 else
//                 {
//                     Console.WriteLine("No hay suficiente stock para retirar esa cantidad.");
//                 }
//             }
//             else
//             {
//                 Console.WriteLine("El producto no existe en el inventario.");
//             }
//             break;

//         case "4":
//             salir = true;
//             break;

//         default:
//             Console.WriteLine("Opción no válida.");
//             break;
//     }
// }
// Console.WriteLine("¡Hasta luego!");

// ejemplo 2
// Dictionary<int, int> calificaciones_sastisfaccion = new Dictionary<int, int>()
// {
//     {1, 0},
//     {2, 0},
//     {3, 0},
//     {4, 0},
//     {5, 0},
// };

// bool salir_encuesta = false;

// while (!salir_encuesta)
// {
//     Console.WriteLine("\n--- Encuesta de Satisfacción ---");
//     Console.WriteLine("1. Califique nuestro servicio del (1 al 5)");
//     Console.WriteLine("2. Ver resultados de la encuesta");
//     Console.WriteLine("3. Salir");
//     Console.Write("Seleccione una opción: ");
//     string opcion_encuesta = Console.ReadLine()!;

//     switch (opcion_encuesta)
//     {
//         case "1":
//         Console.Write("califique nuestro servicio del (1 al 5 ): ");
//         if (int.TryParse(Console.ReadLine(), out int calificacion) && calificacion >= 1 && calificacion <= 5)
//         {
//             calificaciones_sastisfaccion[calificacion]++;
//             Console.WriteLine("Gracias por su calificación.");
//         }
//         else
//         {
//             Console.WriteLine("Calificación no válida. Intente nuevamente.");
//         }
//         break;

//         case "2":
//         Console.WriteLine("Resultados de la encuesta:");
//         for (int i = 1; i <= 5; i++)
//         {
//             Console.WriteLine($"Calificación {i}: {calificaciones_sastisfaccion[i]} votos");
//         }
//         break;

//         case "3":
//         salir_encuesta = true;
//         break;
//         default:
//         Console.WriteLine("Opción no válida.");
//             break;
//     }
// }



