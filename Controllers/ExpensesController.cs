
// using System;
// using ExpenseTracker.Models;
// using ExpenseTracker.Models.DTOs;
// using Microsoft.AspNetCore.Mvc;

// namespace ExpenseTracker.Controllers;

// [Route("api/[controller]")]
// [ApiController]

// public class ExpensesController : ControllerBase
// {
//     private static readonly List<Expense> _expenses = [];

//     [HttpPost]

//     public IActionResult RegisterExpense([FromBody] ExpenseDTO expense)
//     {
//         Expense newExpense = new Expense
//         {
//             Id = Guid.NewGuid(),
//             Description = expense.Description,
//             Amount = expense.Amount,
//             Date = expense.Date,
//             Category = expense.Category,
//             PaymentMethod = expense.PaymentMethod
//         };
        
//         _expenses.Add(newExpense);
//         return CreatedAtAction(nameof(RegisterExpense), new { id = newExpense.Id }, newExpense);
//     }

// }

using ExpenseTracker.Models;
using ExpenseTracker.Models.DTOs;
using Microsoft.AspNetCore.Mvc;

namespace ExpenseTracker.Controllers;

[ApiController]
[Route("api/[controller]")]
public class ExpensesController : ControllerBase
{
    private static readonly List<Expense> _expenses = new();

    [HttpPost]
    public IActionResult RegisterExpense([FromBody] ExpenseDTO expense)
    {
        Expense newExpense = new Expense
        {
            Id = Guid.NewGuid(),
            Description = expense.Description,
            Amount = expense.Amount,
            Date = expense.Date,
            Category = expense.Category,
            PaymentMethod = expense.PaymentMethod
        };

        _expenses.Add(newExpense);

        return Ok(newExpense);
    }

     [HttpGet]
    public IActionResult GetExpenses()

    {
        return Ok(_expenses);
    }
}