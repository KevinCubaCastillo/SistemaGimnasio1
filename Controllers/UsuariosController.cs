using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using SistemaGimansio2.Models;

namespace SistemaGimansio2.Controllers
{
    public class UsuariosController : Controller
    {
        private readonly dn9jbgf4b4ih0Context _context;

        public UsuariosController(dn9jbgf4b4ih0Context context)
        {
            _context = context;
        }
        //Login
        public IActionResult Login()
        {
            ViewData["Estado"] = new SelectList(_context.Estados, "Idestado", "Idestado");
            return View();
        }
        //Verificacion
        [HttpPost]
        [ValidateAntiForgeryToken]
        public IActionResult Verificacion([Bind("Nombreusuario,Contrasenia")] Usuario usuario)
        {
            if(usuario.Nombreusuario != null && usuario.Contrasenia != null)
            {
                var verificacion = _context.Usuarios
            .Where(us => us.Nombreusuario == usuario.Nombreusuario && us.Contrasenia == usuario.Contrasenia)
            .FirstOrDefault();
                if (verificacion == null)
                {
                    ViewBag.Message = "El usuario o la contraseña son incorrectos, vuelva a intentarlo";
                    return View("Login");
                }
                else
                {
                    ViewBag.Message = "Inicio de sesión correcto ✔";
                    return View();
                }
            }
            else
            {
                ViewBag.Message = "Tiene que rellenar todos los campos";
                return View("Login");
            }
        }
        // GET: Usuarios
        public async Task<IActionResult> Index()
        {
            var dn9jbgf4b4ih0Context = _context.Usuarios.Include(u => u.EstadoNavigation);
            return View(await dn9jbgf4b4ih0Context.ToListAsync());
        }

        // GET: Usuarios/Details/5
        public async Task<IActionResult> Details(string id)
        {
            if (id == null || _context.Usuarios == null)
            {
                return NotFound();
            }

            var usuario = await _context.Usuarios
                .Include(u => u.EstadoNavigation)
                .FirstOrDefaultAsync(m => m.Ci == id);
            if (usuario == null)
            {
                return NotFound();
            }

            return View(usuario);
        }

        // GET: Usuarios/Create
        public IActionResult Create()
        {
            ViewData["Estado"] = new SelectList(_context.Estados, "Idestado", "Idestado");
            return View();
        }

        // POST: Usuarios/Create
        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create([Bind("Ci,Nombres,Apellidos,Nombreusuario,Contrasenia,Tipo")] Usuario usuario)
        {
            if (ModelState.IsValid)
            {
                _context.Add(usuario);
                await _context.SaveChangesAsync();
                return RedirectToAction(nameof(Index));
            }
            ViewData["Estado"] = new SelectList(_context.Estados, "Idestado", "Idestado", usuario.Estado);
            return View(usuario);
        }

        // GET: Usuarios/Edit/5
        public async Task<IActionResult> Edit(string id)
        {
            if (id == null || _context.Usuarios == null)
            {
                return NotFound();
            }

            var usuario = await _context.Usuarios.FindAsync(id);
            if (usuario == null)
            {
                return NotFound();
            }
            ViewData["Estado"] = new SelectList(_context.Estados, "Idestado", "Idestado", usuario.Estado);
            return View(usuario);
        }

        // POST: Usuarios/Edit/5
        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(string id, [Bind("Ci,Nombres,Apellidos,Nombreusuario,Contrasenia,Tipo")] Usuario usuario)
        {
            if (id != usuario.Ci)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                try
                {
                    _context.Update(usuario);
                    await _context.SaveChangesAsync();
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!UsuarioExists(usuario.Ci))
                    {
                        return NotFound();
                    }
                    else
                    {
                        throw;
                    }
                }
                return RedirectToAction(nameof(Index));
            }
            ViewData["Estado"] = new SelectList(_context.Estados, "Idestado", "Idestado", usuario.Estado);
            return View(usuario);
        }

        // GET: Usuarios/Delete/5
        public async Task<IActionResult> Delete(string id)
        {
            if (id == null || _context.Usuarios == null)
            {
                return NotFound();
            }

            var usuario = await _context.Usuarios
                .Include(u => u.EstadoNavigation)
                .FirstOrDefaultAsync(m => m.Ci == id);
            if (usuario == null)
            {
                return NotFound();
            }

            return View(usuario);
        }

        // POST: Usuarios/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(string id)
        {
            if (_context.Usuarios == null)
            {
                return Problem("Entity set 'dn9jbgf4b4ih0Context.Usuarios'  is null.");
            }
            var usuario = await _context.Usuarios.FindAsync(id);
            if (usuario != null)
            {
                _context.Usuarios.Remove(usuario);
            }
            
            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }

        private bool UsuarioExists(string id)
        {
          return _context.Usuarios.Any(e => e.Ci == id);
        }
    }
}
