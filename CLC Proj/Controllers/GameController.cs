using CLC_Proj.Models;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CLC_Proj.Controllers
{
    public class GameController : Controller
    {
        Board gameBoard;
        public GameController()
        {
            gameBoard = new Board(1, 8);
        }

        public IActionResult Index()
        {
            gameBoard.Grid[0, 0] = null;
            return View(gameBoard);
        }
    }
}
