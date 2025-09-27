using Microsoft.Win32;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Net.Http;
using System.Net.Http.Json;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;
using DTOs;
namespace WinFormsApp
{
    public partial class Login : Form
    {
        private readonly HttpClient _httpClient;

        public Login()
        {
            InitializeComponent();
            _httpClient = new HttpClient { BaseAddress = new Uri("http://localhost:5183") };
        }

        private void password_TextChanged(object sender, EventArgs e)
        {
            
        }

        private void registrarse_Click(object sender, EventArgs e)
        {
         
            Registro registroForm = new Registro();
            registroForm.Show();
            this.Hide(); 
        }

       

        private async void LogIni_Click(object sender, EventArgs e)
        {
            string correo = usuario.Text;
            string clave = password.Text;

            if (correo == "" || clave == "")
            {
                MessageBox.Show("Por favor, complete todos los campos.");
                return;
            }

            

            try
            {
                try
                {
                    using var health = await _httpClient.GetAsync("/usuarios", HttpCompletionOption.ResponseHeadersRead);
                    if (!health.IsSuccessStatusCode)
                    {
                        var body = await health.Content.ReadAsStringAsync();
                        MessageBox.Show($"API no disponible: {(int)health.StatusCode} {health.ReasonPhrase}. {body}");
                        return;
                    }
                }
                catch (HttpRequestException hre)
                {
                    MessageBox.Show("Error de conexión al API: " + hre.Message + ". Asegúrese de iniciar el WebApi en http://localhost:5183");
                    return;
                }

                // Codificar valores y pedir /Users/{user}/{password} (misma ruta usada en Home.razor)
                var encodedUser = Uri.EscapeDataString(correo);
                var encodedPassword = Uri.EscapeDataString(clave);

                using var resp = await _httpClient.GetAsync($"/usuarios/{encodedUser}/{encodedPassword}");
                if (!resp.IsSuccessStatusCode)
                {
                    MessageBox.Show("User o contraseña incorrecta.");
                    return;
                }

                var User = await resp.Content.ReadFromJsonAsync<UsuarioDTO>();
                if (User == null)
                {
                    MessageBox.Show("Error al procesar datos del User.");
                    return;
                }

                // Obtener persona asociada
                var idPersona = User.IdPersona;
                using var respPersona = await _httpClient.GetAsync($"/personas/{Uri.EscapeDataString(idPersona.ToString())}");
                if (!respPersona.IsSuccessStatusCode)
                {
                    MessageBox.Show("No se encontró la persona asociada al User.");
                    return;
                }

                var persona = await respPersona.Content.ReadFromJsonAsync<PersonaDTO>();
                if (persona == null)
                {
                    MessageBox.Show("Error al obtener datos de la persona.");
                    return;
                }

                if (persona.TipoPersona == 2)
                {
                    MenuAlumno menuAlumno = new MenuAlumno(persona.Id);
                    menuAlumno.Show();
                    this.Hide();
                }
                else if (persona.TipoPersona == 1)
                {
                    MenuProfesor menuProfesor = new MenuProfesor(persona.Id);
                    menuProfesor.Show();
                    this.Hide();

                }
                else
                {
                    MessageBox.Show("Tipo de User desconocido.");
                }
            }
            catch (HttpRequestException ex)
            {
                MessageBox.Show($"No se pudo conectar con la API: {ex.Message}");
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error inesperado: {ex.Message}");
            }
        }

        private void usuarioLabel_Click(object sender, EventArgs e)
        {
            usuario.Focus();
        }

        private void passLabel_Click(object sender, EventArgs e)
        {
            password.Focus();
        }

        private void usuario_TextChanged(object sender, EventArgs e)
        {

        }

        private void Cruds_Click(object sender, EventArgs e)
        {
            menuCrud menuCrud = new menuCrud();
            menuCrud.Show();
            this.Hide();
        }
    }
    }

