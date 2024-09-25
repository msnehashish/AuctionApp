using System;
using AuctionService.Data;
using AuctionService.Entities;
using AutoMapper;
using Microsoft.AspNetCore.Mvc;

namespace AuctionService.Controllers;

[ApiController]
[Route("api/auctions")]
public class AuctionsController:ControllerBase
{
    public readonly AuctionDBContext _context;
    public AuctionsController(AuctionDBContext context, IMapper mapper)
    {
        this._context = context;
    }
}
