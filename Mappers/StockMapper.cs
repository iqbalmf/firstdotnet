using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using firstdotnet.Dto;
using firstdotnet.Models;

namespace firstdotnet.Mappers
{
    public static class StockMapper
    {
    public static StockDto ToStockDto(this Stock stockModel)
        {
            return new StockDto
            {
                Id = stockModel.Id,
                Symbol = stockModel.Symbol,
                CompanyName = stockModel.CompanyName,
                Industry = stockModel.Industry,
                LastDiv = stockModel.LastDiv,
                MarketCap = stockModel.MarketCap,
                Purchase = stockModel.Purchase,
            };
        }

        public static Stock ToStockFromCreateStockDto(this CreateStockRequest createStockRequest)
        {
            return new Stock
            {
                Symbol = createStockRequest.Symbol,
                CompanyName = createStockRequest.CompanyName,
                Industry = createStockRequest.Industry,
                LastDiv = createStockRequest.LastDiv,
                MarketCap = createStockRequest.MarketCap,
                Purchase = createStockRequest.Purchase
            };
        }
    }
}