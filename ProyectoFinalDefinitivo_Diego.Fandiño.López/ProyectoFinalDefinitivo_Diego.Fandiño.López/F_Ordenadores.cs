using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;

namespace ProyectoFinalDefinitivo_Diego.Fandiño.López
{
    public partial class F_Ordenadores : Form
    {
        public F_Ordenadores()
        {
            InitializeComponent();

            //CPU______________________________________________________________
            //TXT CPU Intel
            //Especifica la ruta completa del directorio y del archivo
            string directoryPath = @"C:\Ruta\Completa";
            //Combinar partes de una ruta de archivo o directorio en una sola ruta completa.
            string filePath = Path.Combine(directoryPath, "CPUintel.txt");

            //Llama al método para crear el archivo txt
            CreateTextFile1(filePath);


            //TXT CPU Amd
            //Especifica la ruta completa del directorio y del archivo
            string directoryPath2 = @"C:\Ruta\Completa";
            //Combinar partes de una ruta de archivo o directorio en una sola ruta completa.
            string filePath2 = Path.Combine(directoryPath2, "CPUamd.txt");

            //Llama al método para crear el archivo txt
            CreateTextFile2(filePath2);
            //_________________________________________________________________^


            //RAM___________________________________________________________________
            //TXT RAM DDR3
            //Especifica la ruta completa del directorio y del archivo
            string directoryPath3 = @"C:\Ruta\Completa";
            //Combinar partes de una ruta de archivo o directorio en una sola ruta completa.
            string filePath3 = Path.Combine(directoryPath3, "RAMddr3.txt");

            //Llama al método para crear el archivo txt
            CreateTextFile3(filePath3);

            //TXT RAM DDR4
            //Especifica la ruta completa del directorio y del archivo
            string directoryPath4 = @"C:\Ruta\Completa";
            //Combinar partes de una ruta de archivo o directorio en una sola ruta completa.
            string filePath4 = Path.Combine(directoryPath4, "RAMddr4.txt");

            //Llama al método para crear el archivo txt
            CreateTextFile4(filePath4);

            //TXT RAM DDR5
            //Especifica la ruta completa del directorio y del archivo
            string directoryPath5 = @"C:\Ruta\Completa";
            //Combinar partes de una ruta de archivo o directorio en una sola ruta completa.
            string filePath5 = Path.Combine(directoryPath5, "RAMddr5.txt");

            //Llama al método para crear el archivo txt
            CreateTextFile5(filePath5);
            //____________________________________________________________________^

            //Placa_Base________________________________________________________________________
            //TXT Placa base Intel
            //Especifica la ruta completa del directorio y del archivo
            string directoryPath6 = @"C:\Ruta\Completa";
            //Combinar partes de una ruta de archivo o directorio en una sola ruta completa.
            string filePath6 = Path.Combine(directoryPath6, "PalaBaseIntel.txt");

            //Llama al método para crear el archivo txt
            CreateTextFile6(filePath6);

            //TXT Placa base AMD
            //Especifica la ruta completa del directorio y del archivo
            string directoryPath7 = @"C:\Ruta\Completa";
            //Combinar partes de una ruta de archivo o directorio en una sola ruta completa.
            string filePath7 = Path.Combine(directoryPath7, "PalaBaseAMD.txt");

            //Llama al método para crear el archivo txt
            CreateTextFile7(filePath7);
            //__________________________________________________________________________________^

            //Fuente_Alimentación________________________________________________________________

            //TXT 80+
            //Especifica la ruta completa del directorio y del archivo
            string directoryPath8 = @"C:\Ruta\Completa";
            //Combinar partes de una ruta de archivo o directorio en una sola ruta completa.
            string filePath8 = Path.Combine(directoryPath8, "80+.txt");

            //Llama al método para crear el archivo txt
            CreateTextFile8(filePath8);

            //TXT Bronce
            //Especifica la ruta completa del directorio y del archivo
            string directoryPath9 = @"C:\Ruta\Completa";
            //Combinar partes de una ruta de archivo o directorio en una sola ruta completa.
            string filePath9 = Path.Combine(directoryPath9, "Bronce.txt");

            //Llama al método para crear el archivo txt
            CreateTextFile9(filePath9);

            //TXT Silver
            //Especifica la ruta completa del directorio y del archivo
            string directoryPath10 = @"C:\Ruta\Completa";
            //Combinar partes de una ruta de archivo o directorio en una sola ruta completa.
            string filePath10 = Path.Combine(directoryPath10, "Silver.txt");

            //Llama al método para crear el archivo txt
            CreateTextFile10(filePath10);

            //TXT Gold
            //Especifica la ruta completa del directorio y del archivo
            string directoryPath11 = @"C:\Ruta\Completa";
            //Combinar partes de una ruta de archivo o directorio en una sola ruta completa.
            string filePath11 = Path.Combine(directoryPath11, "Gold.txt");

            //Llama al método para crear el archivo txt
            CreateTextFile11(filePath11);
            //__________________________________________________________________________________^

            //TXT HDD
            //Especifica la ruta completa del directorio y del archivo
            string directoryPath12 = @"C:\Ruta\Completa";
            //Combinar partes de una ruta de archivo o directorio en una sola ruta completa.
            string filePath12 = Path.Combine(directoryPath12, "HDD.txt");

            //Llama al método para crear el archivo txt
            CreateTextFile12(filePath12);

            //TXT SSD
            //Especifica la ruta completa del directorio y del archivo
            string directoryPath13 = @"C:\Ruta\Completa";
            //Combinar partes de una ruta de archivo o directorio en una sola ruta completa.
            string filePath13 = Path.Combine(directoryPath13, "SSD.txt");

            //Llama al método para crear el archivo txt
            CreateTextFile13(filePath13);

            //TXT M.2
            //Especifica la ruta completa del directorio y del archivo
            string directoryPath14 = @"C:\Ruta\Completa";
            //Combinar partes de una ruta de archivo o directorio en una sola ruta completa.
            string filePath14 = Path.Combine(directoryPath14, "M2.txt");

            //Llama al método para crear el archivo txt
            CreateTextFile14(filePath14);
        }



        private void CreateTextFile1(string filePath)
        {
            // Verifica si el directorio existe, si no existe, lo crea
            string directoryPath = Path.GetDirectoryName(filePath);
            if (!Directory.Exists(directoryPath))
            {
                Directory.CreateDirectory(directoryPath);
            }

            if (!File.Exists(filePath))
            {
                try
                {
                    //Intenta crear el archivo y escribir en él
                    using (StreamWriter writer = File.CreateText(filePath))
                    {
                        writer.WriteLine("i9 13 Generación");
                        writer.WriteLine("i9 12 Generación");
                        writer.WriteLine("i9 11 Generación");
                        writer.WriteLine("i7 13 Generación");
                        writer.WriteLine("i7 12 Generación");
                        writer.WriteLine("i7 11 Generación");
                        writer.WriteLine("i5 13 Generación");
                        writer.WriteLine("i5 12 Generación");
                        writer.WriteLine("i5 11 Generación");
                    }
                    MessageBox.Show("Archivo creado con éxito.");
                }
                catch (Exception ex)
                {
                    MessageBox.Show($"Error al crear el archivo: {ex.Message}");
                }
            }
            else
            {
                //MessageBox.Show("El archivo ya existe.");
            }
        }

        private void CreateTextFile2(string filePath2)
        {
            // Verifica si el directorio existe, si no existe, lo crea
            string directoryPath2 = Path.GetDirectoryName(filePath2);
            if (!Directory.Exists(directoryPath2))
            {
                Directory.CreateDirectory(directoryPath2);
            }

            if (!File.Exists(filePath2))
            {
                try
                {
                    //Intenta crear el archivo y escribir en él
                    using (StreamWriter writer = File.CreateText(filePath2))
                    {
                        writer.WriteLine("AMD Ryzen™ 7 8700G");
                        writer.WriteLine("AMD Ryzen™ 5 8600G");
                        writer.WriteLine("AMD Ryzen™ 5 8500G");
                        writer.WriteLine("AMD Ryzen™ 3 8300G");
                        writer.WriteLine("AMD Ryzen™ Embedded 7945");
                        writer.WriteLine("AMD Ryzen™ Embedded 7745");
                        writer.WriteLine("AMD Ryzen™ Embedded 7700X");
                        writer.WriteLine("AMD Ryzen™ Embedded 7645");
                        writer.WriteLine("AMD Ryzen™ Embedded 7600X");
                    }
                    MessageBox.Show("Archivo creado con éxito.");
                }
                catch (Exception ex)
                {
                    MessageBox.Show($"Error al crear el archivo: {ex.Message}");
                }
            }
            else
            {
                //MessageBox.Show("El archivo ya existe.");
            }
        }

        private void CreateTextFile3(string filePath3)
        {
            //Verifica si el directorio existe, si no existe, lo crea
            string directoryPath3 = Path.GetDirectoryName(filePath3);
            if (!Directory.Exists(directoryPath3))
            {
                Directory.CreateDirectory(directoryPath3);
            }

            if (!File.Exists(filePath3))
            {
                try
                {
                    //Intenta crear el archivo y escribir en él
                    using (StreamWriter writer = File.CreateText(filePath3))
                    {
                        writer.WriteLine("Corsair 16GB 1600MHz");
                        writer.WriteLine("Timetec 8GB 1600MHz");
                        writer.WriteLine("Timetec 4GB 1333MHz");
                        writer.WriteLine("Corsair 8GB 1333MHz");
                        writer.WriteLine("Samsung 16GB 1600MHz");
                    }
                    MessageBox.Show("Archivo creado con éxito.");
                }
                catch (Exception ex)
                {
                    MessageBox.Show($"Error al crear el archivo: {ex.Message}");
                }
            }
            else
            {
                //MessageBox.Show("El archivo ya existe.");
            }
        }

        private void CreateTextFile4(string filePath4)
        {
            //Verifica si el directorio existe, si no existe, lo crea
            string directoryPath4 = Path.GetDirectoryName(filePath4);
            if (!Directory.Exists(directoryPath4))
            {
                Directory.CreateDirectory(directoryPath4);
            }

            if (!File.Exists(filePath4))
            {
                try
                {
                    //Intenta crear el archivo y escribir en él
                    using (StreamWriter writer = File.CreateText(filePath4))
                    {
                        writer.WriteLine("Corsair 16GB 3200MHz");
                        writer.WriteLine("Corsair 8GB 2666MHz");
                        writer.WriteLine("Samsung 16GB 3600MHz");
                        writer.WriteLine("Corsair 8GB 2400MHz");
                        writer.WriteLine("Samsung 16GB 3200MHz");
                        writer.WriteLine("Kingston 16GB 3200MHz");
                    }
                    MessageBox.Show("Archivo creado con éxito.");
                }
                catch (Exception ex)
                {
                    MessageBox.Show($"Error al crear el archivo: {ex.Message}");
                }
            }
            else
            {
                //MessageBox.Show("El archivo ya existe.");
            }
        }

        private void CreateTextFile5(string filePath5)
        {
            //Verifica si el directorio existe, si no existe, lo crea
            string directoryPath5 = Path.GetDirectoryName(filePath5);
            if (!Directory.Exists(directoryPath5))
            {
                Directory.CreateDirectory(directoryPath5);
            }

            if (!File.Exists(filePath5))
            {
                try
                {
                    //Intenta crear el archivo y escribir en él
                    using (StreamWriter writer = File.CreateText(filePath5))
                    {
                        writer.WriteLine("Acer Predator 16GB 6000MHz");
                        writer.WriteLine("Corsair Vengeance 32GB 6400MHz");
                        writer.WriteLine("Kingston FURY 16GB 6000MHz");
                        writer.WriteLine("Corsair 16GB 4800MHz");
                        writer.WriteLine("Adata 16GB 4800MHz");
                    }
                    MessageBox.Show("Archivo creado con éxito.");
                }
                catch (Exception ex)
                {
                    MessageBox.Show($"Error al crear el archivo: {ex.Message}");
                }
            }
            else
            {
                //MessageBox.Show("El archivo ya existe.");
            }
        }

        private void CreateTextFile6(string filePath6)
        {
            //Verifica si el directorio existe, si no existe, lo crea
            string directoryPath6 = Path.GetDirectoryName(filePath6);
            if (!Directory.Exists(directoryPath6))
            {
                Directory.CreateDirectory(directoryPath6);
            }

            if (!File.Exists(filePath6))
            {
                try
                {
                    //Intenta crear el archivo y escribir en él
                    using (StreamWriter writer = File.CreateText(filePath6))
                    {
                        writer.WriteLine("ASUS P11C-X");
                        writer.WriteLine("ASUS PRIME H610M-A");
                        writer.WriteLine("ASUS PRIME B660-PLUS");
                        writer.WriteLine("MSI PRO Z790-A MAX");
                        writer.WriteLine("Gigabyte B760 Gaming X");
                        writer.WriteLine("Asrock Z690 PG Riptide");
                        writer.WriteLine("MSI PRO H510M-B");
                    }
                    MessageBox.Show("Archivo creado con éxito.");
                }
                catch (Exception ex)
                {
                    MessageBox.Show($"Error al crear el archivo: {ex.Message}");
                }
            }
            else
            {
                //MessageBox.Show("El archivo ya existe.");
            }
        }

        private void CreateTextFile7(string filePath7)
        {
            //Verifica si el directorio existe, si no existe, lo crea
            string directoryPath7 = Path.GetDirectoryName(filePath7);
            if (!Directory.Exists(directoryPath7))
            {
                Directory.CreateDirectory(directoryPath7);
            }

            if (!File.Exists(filePath7))
            {
                try
                {
                    //Intenta crear el archivo y escribir en él
                    using (StreamWriter writer = File.CreateText(filePath7))
                    {
                        writer.WriteLine("Gigabyte B550M DS3H AC");
                        writer.WriteLine("ASUS PRIME B550M-A/CSM");
                        writer.WriteLine("Gigabyte B550M K Rev. 1.0");
                        writer.WriteLine("MSI MAG B550");
                        writer.WriteLine("ASRock B550M-ITX/AC");
                        writer.WriteLine("Asus TUF GAMING B550-PLUS");
                    }
                    MessageBox.Show("Archivo creado con éxito.");
                }
                catch (Exception ex)
                {
                    MessageBox.Show($"Error al crear el archivo: {ex.Message}");
                }
            }
            else
            {
                //MessageBox.Show("El archivo ya existe.");
            }
        }

        private void CreateTextFile8(string filePath8)
        {
            //Verifica si el directorio existe, si no existe, lo crea
            string directoryPath8 = Path.GetDirectoryName(filePath8);
            if (!Directory.Exists(directoryPath8))
            {
                Directory.CreateDirectory(directoryPath8);
            }

            if (!File.Exists(filePath8))
            {
                try
                {
                    //Intenta crear el archivo y escribir en él
                    using (StreamWriter writer = File.CreateText(filePath8))
                    {
                        writer.WriteLine("3Go Lite Series 500W");
                        writer.WriteLine("Tooq Ecopower II TQEP-500SSE-O 500W");
                        writer.WriteLine("UNYKAch Fuente de Alimentación SFX 450W");
                        writer.WriteLine("Approx APP500LITENV2 500W PFC");
                        writer.WriteLine("Tooq Ecopower II 500W");
                        writer.WriteLine("Tooq Ecopower II TQEP-500SSE 500W");
                    }
                    MessageBox.Show("Archivo creado con éxito.");
                }
                catch (Exception ex)
                {
                    MessageBox.Show($"Error al crear el archivo: {ex.Message}");
                }
            }
            else
            {
                //MessageBox.Show("El archivo ya existe.");
            }
        }

        private void CreateTextFile9(string filePath9)
        {
            //Verifica si el directorio existe, si no existe, lo crea
            string directoryPath9 = Path.GetDirectoryName(filePath9);
            if (!Directory.Exists(directoryPath9))
            {
                Directory.CreateDirectory(directoryPath9);
            }

            if (!File.Exists(filePath9))
            {
                try
                {
                    //Intenta crear el archivo y escribir en él
                    using (StreamWriter writer = File.CreateText(filePath9))
                    {
                        writer.WriteLine("UNYKAch Fuente de Alimentación 350W");
                        writer.WriteLine("Tacens Anima APB550B 550W");
                        writer.WriteLine("Mars Gaming MPB550 550W");
                        writer.WriteLine("Tacens Anima APB550 ATX 550W");
                        writer.WriteLine("UNYKAch Fuente de Alimentación TFX 350W");
                        writer.WriteLine("UNYKAch Atilius 2.0 Black 500W");
                        writer.WriteLine("NOX Hummer Alpha 500W");
                    }
                    MessageBox.Show("Archivo creado con éxito.");
                }
                catch (Exception ex)
                {
                    MessageBox.Show($"Error al crear el archivo: {ex.Message}");
                }
            }
            else
            {
                //MessageBox.Show("El archivo ya existe.");
            }
        }

        private void CreateTextFile10(string filePath10)
        {
            //Verifica si el directorio existe, si no existe, lo crea
            string directoryPath10 = Path.GetDirectoryName(filePath10);
            if (!Directory.Exists(directoryPath10))
            {
                Directory.CreateDirectory(directoryPath10);
            }

            if (!File.Exists(filePath10))
            {
                try
                {
                    //Intenta crear el archivo y escribir en él
                    using (StreamWriter writer = File.CreateText(filePath10))
                    {
                        writer.WriteLine("Tacens Radix VII AG 600W");
                        writer.WriteLine("Tacens Radix VII AG 700M 700W");
                        writer.WriteLine("Tacens Radix VII AG 800M 800W");
                        writer.WriteLine("Mars Gaming MPVU750M 750W");
                        writer.WriteLine("L-Link LL-PS-800-80+S 800W");
                        writer.WriteLine("Mars Gaming Vulcano 750W");
                    }
                    MessageBox.Show("Archivo creado con éxito.");
                }
                catch (Exception ex)
                {
                    MessageBox.Show($"Error al crear el archivo: {ex.Message}");
                }
            }
            else
            {
                //MessageBox.Show("El archivo ya existe.");
            }
        }

        private void CreateTextFile11(string filePath11)
        {
            //Verifica si el directorio existe, si no existe, lo crea
            string directoryPath11 = Path.GetDirectoryName(filePath11);
            if (!Directory.Exists(directoryPath11))
            {
                Directory.CreateDirectory(directoryPath11);
            }

            if (!File.Exists(filePath11))
            {
                try
                {
                    //Intenta crear el archivo y escribir en él
                    using (StreamWriter writer = File.CreateText(filePath11))
                    {
                        writer.WriteLine("Be Quiet! Pure Power 11 400W");
                        writer.WriteLine("Aerocool Mirage Gold RGB 650W");
                        writer.WriteLine("Fuente Alimentación CoolBox Core-G 500W");
                        writer.WriteLine("Kolink Enclave 600W");
                        writer.WriteLine("Seasonic G12 GC 650W");
                        writer.WriteLine("Be Quiet! Pure Power 11 500W");
                        writer.WriteLine("Aerocool Mirage Gold RGB 650W");
                    }
                    MessageBox.Show("Archivo creado con éxito.");
                }
                catch (Exception ex)
                {
                    MessageBox.Show($"Error al crear el archivo: {ex.Message}");
                }
            }
            else
            {
                //MessageBox.Show("El archivo ya existe.");
            }
        }

        private void CreateTextFile12(string filePath12)
        {
            //Verifica si el directorio existe, si no existe, lo crea
            string directoryPath12 = Path.GetDirectoryName(filePath12);
            if (!Directory.Exists(directoryPath12))
            {
                Directory.CreateDirectory(directoryPath12);
            }

            if (!File.Exists(filePath12))
            {
                try
                {
                    //Intenta crear el archivo y escribir en él
                    using (StreamWriter writer = File.CreateText(filePath12))
                    {
                        writer.WriteLine("Seagate BarraCuda 3.5, 1TB");
                        writer.WriteLine("Toshiba Canvio Basics 2022 2.5, 4TB");
                        writer.WriteLine("WD Red Plus 3.5, 8TB");
                        writer.WriteLine("WD Elements 2TB 2.5");
                        writer.WriteLine("Disco Duro Seagate IronWolf NAS 3.5, 12TB");
                        writer.WriteLine("WD Red Pro 3.5, 14TB");
                        writer.WriteLine("Disco Duro Seagate Expansion 3.5, 18TB");
                    }
                    MessageBox.Show("Archivo creado con éxito.");
                }
                catch (Exception ex)
                {
                    MessageBox.Show($"Error al crear el archivo: {ex.Message}");
                }
            }
            else
            {
                //MessageBox.Show("El archivo ya existe.");
            }
        }

        private void CreateTextFile13(string filePath13)
        {
            //Verifica si el directorio existe, si no existe, lo crea
            string directoryPath13 = Path.GetDirectoryName(filePath13);
            if (!Directory.Exists(directoryPath13))
            {
                Directory.CreateDirectory(directoryPath13);
            }

            if (!File.Exists(filePath13))
            {
                try
                {
                    //Intenta crear el archivo y escribir en él
                    using (StreamWriter writer = File.CreateText(filePath13))
                    {
                        writer.WriteLine("Intenso Top SSD 128 GB");
                        writer.WriteLine("Adata SU650 SSD 120GB");
                        writer.WriteLine("GoodRam CL100 Gen.3 2.5, 120GB");
                        writer.WriteLine("PNY CS900 2.5, 240GB");
                        writer.WriteLine("PNY CS900 2.5, 500GB");
                        writer.WriteLine("SanDisk Ultra 3D 2.5, 500GB");
                        writer.WriteLine("Samsung 870 EVO SSD 2.5, 500GB");
                    }
                    MessageBox.Show("Archivo creado con éxito.");
                }
                catch (Exception ex)
                {
                    MessageBox.Show($"Error al crear el archivo: {ex.Message}");
                }
            }
            else
            {
                //MessageBox.Show("El archivo ya existe.");
            }
        }

        private void CreateTextFile14(string filePath14)
        {
            //Verifica si el directorio existe, si no existe, lo crea
            string directoryPath14 = Path.GetDirectoryName(filePath14);
            if (!Directory.Exists(directoryPath14))
            {
                Directory.CreateDirectory(directoryPath14);
            }

            if (!File.Exists(filePath14))
            {
                try
                {
                    //Intenta crear el archivo y escribir en él
                    using (StreamWriter writer = File.CreateText(filePath14))
                    {
                        writer.WriteLine("WD BLACK SN770 2TB");
                        writer.WriteLine("Kioxia Exceria Pro 1TB");
                        writer.WriteLine("Kioxia Exceria G2 500GB");
                        writer.WriteLine("Kingston NV2 500GB");
                        writer.WriteLine("Kingston KC3000 1TB");
                        writer.WriteLine("Acer Predator GM7 4TB");
                        writer.WriteLine("WD Black SN850X 1TB");
                    }
                    MessageBox.Show("Archivo creado con éxito.");
                }
                catch (Exception ex)
                {
                    MessageBox.Show($"Error al crear el archivo: {ex.Message}");
                }
            }
            else
            {
                //MessageBox.Show("El archivo ya existe.");
            }
        }

        //Función CPU_______________________________________________________________
        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {
            //CPU Intel
            if (checkBox1.Checked)
            {
                checkBox2.Checked = false;

                //Cargar el contenido del archivo en el ComboBox
                LoadComboBoxFromFile(@"C:\Ruta\Completa\CPUintel.txt");
            }

            /*if (checkBox1.Checked)
            {
                comboBox1.Items.Clear();
                comboBox1.Items.Add("i9 11 Generación");
                comboBox1.Items.Add("i9 12 Generación");
                comboBox1.Items.Add("i9 13 Generación");
                comboBox1.Items.Add("i7 11 Generación");
                comboBox1.Items.Add("i7 12 Generación");
                comboBox1.Items.Add("i7 13 Generación");
                comboBox1.Items.Add("i5 11 Generación");
                comboBox1.Items.Add("i5 12 Generación");
                comboBox1.Items.Add("i5 13 Generación");
            }*/

        }


        private void LoadComboBoxFromFile(string filePath)
        {
            //Borra todos los elementos existentes en el ComboBox
            comboBox1.Items.Clear();

            try
            {
                //Abre el archivo especificado en filePath para lectura
                //utilizando un StreamReader
                using (StreamReader reader = new StreamReader(filePath))
                {
                    string line; //Variable para almacenar cada línea del archivo

                    //Lee cada línea del archivo una por una hasta que se alcanza el final del archivo
                    //(cuando ReadLine() devuelve null)
                    while ((line = reader.ReadLine()) != null)
                    {
                        //Agrega cada línea del archivo como un elemento al ComboBox
                        comboBox1.Items.Add(line);
                    }
                }
            }
            catch (Exception ex)
            {
                //Si ocurre una excepción, muestra un mensaje de error al usuario
                //que indica que ha habido un problema al leer el archivo.
                //El mensaje de error incluye el mensaje de la excepción (ex.Message),
                //que proporciona detalles sobre el tipo de error que ocurrió.
                MessageBox.Show($"Error al leer el archivo: {ex.Message}");
            }
        }


        private void checkBox2_CheckedChanged(object sender, EventArgs e)
        {
            //CPU Amd
            if (checkBox2.Checked)
            {
                checkBox1.Checked = false;

                //Cargar el contenido del archivo en el ComboBox
                LoadComboBoxFromFile(@"C:\Ruta\Completa\CPUamd.txt");
            }
        }
        //__________________________________________________________________________^

        //RAM________________________________________________________________________
        private void checkBox3_CheckedChanged(object sender, EventArgs e)
        {
            //RAM DDR3
            if (checkBox3.Checked)
            {
                checkBox4.Checked = false;
                checkBox5.Checked = false;

                //Cargar el contenido del archivo en el ComboBox
                LoadComboBoxFromFile2(@"C:\Ruta\Completa\RAMddr3.txt");
            }
        }

        private void checkBox4_CheckedChanged(object sender, EventArgs e)
        {
            //RAM DDR4
            if (checkBox4.Checked)
            {
                checkBox3.Checked = false;
                checkBox5.Checked = false;

                //Cargar el contenido del archivo en el ComboBox
                LoadComboBoxFromFile2(@"C:\Ruta\Completa\RAMddr4.txt");
            }
        }

        private void checkBox5_CheckedChanged(object sender, EventArgs e)
        {
            //RAM DDR5
            if (checkBox5.Checked)
            {
                checkBox4.Checked = false;
                checkBox3.Checked = false;

                //Cargar el contenido del archivo en el ComboBox
                LoadComboBoxFromFile2(@"C:\Ruta\Completa\RAMddr5.txt");
            }
        }
        private void LoadComboBoxFromFile2(string filePath)
        {
            //Borra todos los elementos existentes en el ComboBox
            comboBox2.Items.Clear();

            try
            {
                //Abre el archivo especificado en filePath para lectura
                //utilizando un StreamReader
                using (StreamReader reader = new StreamReader(filePath))
                {
                    string line; //Variable para almacenar cada línea del archivo

                    //Lee cada línea del archivo una por una hasta que se alcanza el final del archivo
                    //(cuando ReadLine() devuelve null)
                    while ((line = reader.ReadLine()) != null)
                    {
                        //Agrega cada línea del archivo como un elemento al ComboBox
                        comboBox2.Items.Add(line);
                    }
                }
            }
            catch (Exception ex)
            {
                //Si ocurre una excepción, muestra un mensaje de error al usuario
                //que indica que ha habido un problema al leer el archivo.
                //El mensaje de error incluye el mensaje de la excepción (ex.Message),
                //que proporciona detalles sobre el tipo de error que ocurrió.
                MessageBox.Show($"Error al leer el archivo: {ex.Message}");
            }
        }
        //______________________________________________________________________________________^

        //Placa_base_____________________________________________________________________________
        private void checkBox17_CheckedChanged(object sender, EventArgs e)
        {
            //Placa base Intel
            if (checkBox17.Checked)
            {
                checkBox16.Checked = false;

                //Cargar el contenido del archivo en el ComboBox
                LoadComboBoxFromFile3(@"C:\Ruta\Completa\PalaBaseIntel.txt");
            }
        }

        private void checkBox16_CheckedChanged(object sender, EventArgs e)
        {
            //Placa base AMD
            if (checkBox16.Checked)
            {
                checkBox17.Checked = false;

                //Cargar el contenido del archivo en el ComboBox
                LoadComboBoxFromFile3(@"C:\Ruta\Completa\PalaBaseAMD.txt");
            }
        }
        private void LoadComboBoxFromFile3(string filePath)
        {
            //Borra todos los elementos existentes en el ComboBox
            comboBox3.Items.Clear();

            try
            {
                //Abre el archivo especificado en filePath para lectura
                //utilizando un StreamReader
                using (StreamReader reader = new StreamReader(filePath))
                {
                    string line; //Variable para almacenar cada línea del archivo

                    //Lee cada línea del archivo una por una hasta que se alcanza el final del archivo
                    //(cuando ReadLine() devuelve null)
                    while ((line = reader.ReadLine()) != null)
                    {
                        //Agrega cada línea del archivo como un elemento al ComboBox
                        comboBox3.Items.Add(line);
                    }
                }
            }
            catch (Exception ex)
            {
                //Si ocurre una excepción, muestra un mensaje de error al usuario
                //que indica que ha habido un problema al leer el archivo.
                //El mensaje de error incluye el mensaje de la excepción (ex.Message),
                //que proporciona detalles sobre el tipo de error que ocurrió.
                MessageBox.Show($"Error al leer el archivo: {ex.Message}");
            }
        }
        //_____________________________________________________________________________________^

        //Fuente_Alimentación___________________________________________________________________
        private void checkBox6_CheckedChanged(object sender, EventArgs e)
        {
            //80+
            if (checkBox6.Checked)
            {
                checkBox7.Checked = false;
                checkBox8.Checked = false;
                checkBox9.Checked = false;

                //Cargar el contenido del archivo en el ComboBox
                LoadComboBoxFromFile4(@"C:\Ruta\Completa\80+.txt");
            }
        }

        private void checkBox7_CheckedChanged(object sender, EventArgs e)
        {
            //Bronce
            if (checkBox7.Checked)
            {
                checkBox6.Checked = false;
                checkBox8.Checked = false;
                checkBox9.Checked = false;

                //Cargar el contenido del archivo en el ComboBox
                LoadComboBoxFromFile4(@"C:\Ruta\Completa\Bronce.txt");
            }
        }

        private void checkBox8_CheckedChanged(object sender, EventArgs e)
        {
            //Silver
            if (checkBox8.Checked)
            {
                checkBox7.Checked = false;
                checkBox6.Checked = false;
                checkBox9.Checked = false;

                //Cargar el contenido del archivo en el ComboBox
                LoadComboBoxFromFile4(@"C:\Ruta\Completa\Silver.txt");
            }
        }

        private void checkBox9_CheckedChanged(object sender, EventArgs e)
        {
            //Gold
            if (checkBox9.Checked)
            {
                checkBox7.Checked = false;
                checkBox8.Checked = false;
                checkBox6.Checked = false;

                //Cargar el contenido del archivo en el ComboBox
                LoadComboBoxFromFile4(@"C:\Ruta\Completa\Gold.txt");
            }
        }

        private void LoadComboBoxFromFile4(string filePath)
        {
            //Borra todos los elementos existentes en el ComboBox
            comboBox4.Items.Clear();

            try
            {
                //Abre el archivo especificado en filePath para lectura
                //utilizando un StreamReader
                using (StreamReader reader = new StreamReader(filePath))
                {
                    string line; //Variable para almacenar cada línea del archivo

                    //Lee cada línea del archivo una por una hasta que se alcanza el final del archivo
                    //(cuando ReadLine() devuelve null)
                    while ((line = reader.ReadLine()) != null)
                    {
                        //Agrega cada línea del archivo como un elemento al ComboBox
                        comboBox4.Items.Add(line);
                    }
                }
            }
            catch (Exception ex)
            {
                //Si ocurre una excepción, muestra un mensaje de error al usuario
                //que indica que ha habido un problema al leer el archivo.
                //El mensaje de error incluye el mensaje de la excepción (ex.Message),
                //que proporciona detalles sobre el tipo de error que ocurrió.
                MessageBox.Show($"Error al leer el archivo: {ex.Message}");
            }
            //__________________________________________________________________________________________^


        }

        private void checkBox13_CheckedChanged(object sender, EventArgs e)
        {
            //HDD
            if (checkBox13.Checked)
            {
                checkBox11.Checked = false;
                checkBox12.Checked = false;

                //Cargar el contenido del archivo en el ComboBox
                LoadComboBoxFromFile5(@"C:\Ruta\Completa\HDD.txt");
            }
        }

        private void checkBox12_CheckedChanged(object sender, EventArgs e)
        {
            //SSD
            if (checkBox12.Checked)
            {
                checkBox11.Checked = false;
                checkBox13.Checked = false;

                //Cargar el contenido del archivo en el ComboBox
                LoadComboBoxFromFile5(@"C:\Ruta\Completa\SSD.txt");
            }
        }

        private void checkBox11_CheckedChanged(object sender, EventArgs e)
        {
            //M.2
            if (checkBox11.Checked)
            {
                checkBox13.Checked = false;
                checkBox12.Checked = false;

                //Cargar el contenido del archivo en el ComboBox
                LoadComboBoxFromFile5(@"C:\Ruta\Completa\M2.txt");
            }
        }

        private void LoadComboBoxFromFile5(string filePath)
        {
            //Borra todos los elementos existentes en el ComboBox
            comboBox5.Items.Clear();

            try
            {
                //Abre el archivo especificado en filePath para lectura
                //utilizando un StreamReader
                using (StreamReader reader = new StreamReader(filePath))
                {
                    string line; //Variable para almacenar cada línea del archivo

                    //Lee cada línea del archivo una por una hasta que se alcanza el final del archivo
                    //(cuando ReadLine() devuelve null)
                    while ((line = reader.ReadLine()) != null)
                    {
                        //Agrega cada línea del archivo como un elemento al ComboBox
                        comboBox5.Items.Add(line);
                    }
                }
            }
            catch (Exception ex)
            {
                //Si ocurre una excepción, muestra un mensaje de error al usuario
                //que indica que ha habido un problema al leer el archivo.
                //El mensaje de error incluye el mensaje de la excepción (ex.Message),
                //que proporciona detalles sobre el tipo de error que ocurrió.
                MessageBox.Show($"Error al leer el archivo: {ex.Message}");
            }
        }
    }
}
