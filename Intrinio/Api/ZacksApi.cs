

using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using RestSharp;
using Intrinio.Client;
using Intrinio.Model;

namespace Intrinio.Api
{
    /// <summary>
    /// Represents a collection of functions to interact with the API endpoints
    /// </summary>
    public interface IZacksApi : IApiAccessor
    {
        #region Synchronous Operations
        /// <summary>
        /// Zacks Analyst Ratings
        /// </summary>
        /// <remarks>
        /// Returns buy, sell, and hold recommendations from analysts at brokerages for all companies in the Zacks universe. Zack’s storied research team aggregates and validates the ratings from professional analysts.
        /// </remarks>
        /// <exception cref="Intrinio.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="identifier">A Security identifier (Ticker, FIGI, ISIN, CUSIP, Intrinio ID) (optional)</param>
        /// <param name="startDate">Limit ratings to those on or after this date (optional)</param>
        /// <param name="endDate">Limit ratings to those on or before this date (optional)</param>
        /// <param name="meanGreater">Return only records with a mean (average) higher than this value (optional)</param>
        /// <param name="meanLess">Return only records with a mean (average) lower than this value (optional)</param>
        /// <param name="strongBuysGreater">Return only records with more than this many Strong Buy recommendations (optional)</param>
        /// <param name="strongBuysLess">Return only records with fewer than this many Strong Buy recommendations (optional)</param>
        /// <param name="buysGreater">Return only records with more than this many Buy recommendations (optional)</param>
        /// <param name="buysLess">Return only records with fewer than this many Buy recommendations (optional)</param>
        /// <param name="holdsGreater">Return only records with more than this many Hold recommendations (optional)</param>
        /// <param name="holdsLess">Return only records with fewer than this many Hold recommendations (optional)</param>
        /// <param name="sellsGreater">Return only records with more than this many Sell recommendations (optional)</param>
        /// <param name="sellsLess">Return only records with fewer than this many Sell recommendations (optional)</param>
        /// <param name="strongSellsGreater">Return only records with more than this many Strong Sell recommendations (optional)</param>
        /// <param name="strongSellsLess">Return only records with fewer than this many Strong Sell recommendations (optional)</param>
        /// <param name="totalGreater">Return only records with more than this many recommendations, regardless of type (optional)</param>
        /// <param name="totalLess">Return only records with fewer than this many recommendations, regardless of type (optional)</param>
        /// <param name="pageSize">The number of results to return (optional, default to 100)</param>
        /// <param name="nextPage">Gets the next page of data from a previous API call (optional)</param>
        /// <returns>ApiResponseZacksAnalystRatings</returns>
        ApiResponseZacksAnalystRatings GetZacksAnalystRatings (string identifier = null, string startDate = null, string endDate = null, decimal? meanGreater = null, decimal? meanLess = null, int? strongBuysGreater = null, int? strongBuysLess = null, int? buysGreater = null, int? buysLess = null, int? holdsGreater = null, int? holdsLess = null, int? sellsGreater = null, int? sellsLess = null, int? strongSellsGreater = null, int? strongSellsLess = null, int? totalGreater = null, int? totalLess = null, int? pageSize = null, string nextPage = null);

        /// <summary>
        /// Zacks Analyst Ratings
        /// </summary>
        /// <remarks>
        /// Returns buy, sell, and hold recommendations from analysts at brokerages for all companies in the Zacks universe. Zack’s storied research team aggregates and validates the ratings from professional analysts.
        /// </remarks>
        /// <exception cref="Intrinio.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="identifier">A Security identifier (Ticker, FIGI, ISIN, CUSIP, Intrinio ID) (optional)</param>
        /// <param name="startDate">Limit ratings to those on or after this date (optional)</param>
        /// <param name="endDate">Limit ratings to those on or before this date (optional)</param>
        /// <param name="meanGreater">Return only records with a mean (average) higher than this value (optional)</param>
        /// <param name="meanLess">Return only records with a mean (average) lower than this value (optional)</param>
        /// <param name="strongBuysGreater">Return only records with more than this many Strong Buy recommendations (optional)</param>
        /// <param name="strongBuysLess">Return only records with fewer than this many Strong Buy recommendations (optional)</param>
        /// <param name="buysGreater">Return only records with more than this many Buy recommendations (optional)</param>
        /// <param name="buysLess">Return only records with fewer than this many Buy recommendations (optional)</param>
        /// <param name="holdsGreater">Return only records with more than this many Hold recommendations (optional)</param>
        /// <param name="holdsLess">Return only records with fewer than this many Hold recommendations (optional)</param>
        /// <param name="sellsGreater">Return only records with more than this many Sell recommendations (optional)</param>
        /// <param name="sellsLess">Return only records with fewer than this many Sell recommendations (optional)</param>
        /// <param name="strongSellsGreater">Return only records with more than this many Strong Sell recommendations (optional)</param>
        /// <param name="strongSellsLess">Return only records with fewer than this many Strong Sell recommendations (optional)</param>
        /// <param name="totalGreater">Return only records with more than this many recommendations, regardless of type (optional)</param>
        /// <param name="totalLess">Return only records with fewer than this many recommendations, regardless of type (optional)</param>
        /// <param name="pageSize">The number of results to return (optional, default to 100)</param>
        /// <param name="nextPage">Gets the next page of data from a previous API call (optional)</param>
        /// <returns>ApiResponse of ApiResponseZacksAnalystRatings</returns>
        ApiResponse<ApiResponseZacksAnalystRatings> GetZacksAnalystRatingsWithHttpInfo (string identifier = null, string startDate = null, string endDate = null, decimal? meanGreater = null, decimal? meanLess = null, int? strongBuysGreater = null, int? strongBuysLess = null, int? buysGreater = null, int? buysLess = null, int? holdsGreater = null, int? holdsLess = null, int? sellsGreater = null, int? sellsLess = null, int? strongSellsGreater = null, int? strongSellsLess = null, int? totalGreater = null, int? totalLess = null, int? pageSize = null, string nextPage = null);
        /// <summary>
        /// Zacks EPS Surprises
        /// </summary>
        /// <remarks>
        /// Returns Zacks eps surprise data for all Securities.
        /// </remarks>
        /// <exception cref="Intrinio.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="startDate">Limit EPS surprises to those on or after this date (optional)</param>
        /// <param name="endDate">Limit EPS surprises to those on or before this date (optional)</param>
        /// <param name="epsActualGreater">Return only records with an actual EPS higher than this value (optional)</param>
        /// <param name="epsActualLess">Return only records with an actual EPS lower than this value (optional)</param>
        /// <param name="epsMeanEstimateGreater">Return only records with an EPS mean estimate greater than this value (optional)</param>
        /// <param name="epsMeanEstimateLess">Return only records with an EPS mean estimate lower than this value (optional)</param>
        /// <param name="epsAmountDiffGreater">Return only records with an EPS amount difference greater than this value (optional)</param>
        /// <param name="epsAmountDiffLess">Return only records with an EPS amount difference less than this value (optional)</param>
        /// <param name="epsPercentDiffGreater">Return only records with an EPS percent difference greater than this value (optional)</param>
        /// <param name="epsPercentDiffLess">Return only records with an EPS percent difference less than this value (optional)</param>
        /// <param name="epsCountEstimateGreater">Return only records with an EPS count estimate greater than this value (optional)</param>
        /// <param name="epsCountEstimateLess">Return only records with an EPS count estimate less than this value (optional)</param>
        /// <param name="epsStdDevEstimateGreater">Return only records with an EPS standard deviation greater than this value (optional)</param>
        /// <param name="epsStdDevEstimateLess">Return only records with an EPS standard deviation less than this value (optional)</param>
        /// <param name="pageSize">The number of results to return (optional, default to 100)</param>
        /// <param name="nextPage">Gets the next page of data from a previous API call (optional)</param>
        /// <returns>ApiResponseZacksEPSSurprises</returns>
        ApiResponseZacksEPSSurprises GetZacksEpsSurprises (string startDate = null, string endDate = null, decimal? epsActualGreater = null, decimal? epsActualLess = null, decimal? epsMeanEstimateGreater = null, decimal? epsMeanEstimateLess = null, decimal? epsAmountDiffGreater = null, decimal? epsAmountDiffLess = null, decimal? epsPercentDiffGreater = null, decimal? epsPercentDiffLess = null, decimal? epsCountEstimateGreater = null, decimal? epsCountEstimateLess = null, decimal? epsStdDevEstimateGreater = null, decimal? epsStdDevEstimateLess = null, int? pageSize = null, string nextPage = null);

        /// <summary>
        /// Zacks EPS Surprises
        /// </summary>
        /// <remarks>
        /// Returns Zacks eps surprise data for all Securities.
        /// </remarks>
        /// <exception cref="Intrinio.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="startDate">Limit EPS surprises to those on or after this date (optional)</param>
        /// <param name="endDate">Limit EPS surprises to those on or before this date (optional)</param>
        /// <param name="epsActualGreater">Return only records with an actual EPS higher than this value (optional)</param>
        /// <param name="epsActualLess">Return only records with an actual EPS lower than this value (optional)</param>
        /// <param name="epsMeanEstimateGreater">Return only records with an EPS mean estimate greater than this value (optional)</param>
        /// <param name="epsMeanEstimateLess">Return only records with an EPS mean estimate lower than this value (optional)</param>
        /// <param name="epsAmountDiffGreater">Return only records with an EPS amount difference greater than this value (optional)</param>
        /// <param name="epsAmountDiffLess">Return only records with an EPS amount difference less than this value (optional)</param>
        /// <param name="epsPercentDiffGreater">Return only records with an EPS percent difference greater than this value (optional)</param>
        /// <param name="epsPercentDiffLess">Return only records with an EPS percent difference less than this value (optional)</param>
        /// <param name="epsCountEstimateGreater">Return only records with an EPS count estimate greater than this value (optional)</param>
        /// <param name="epsCountEstimateLess">Return only records with an EPS count estimate less than this value (optional)</param>
        /// <param name="epsStdDevEstimateGreater">Return only records with an EPS standard deviation greater than this value (optional)</param>
        /// <param name="epsStdDevEstimateLess">Return only records with an EPS standard deviation less than this value (optional)</param>
        /// <param name="pageSize">The number of results to return (optional, default to 100)</param>
        /// <param name="nextPage">Gets the next page of data from a previous API call (optional)</param>
        /// <returns>ApiResponse of ApiResponseZacksEPSSurprises</returns>
        ApiResponse<ApiResponseZacksEPSSurprises> GetZacksEpsSurprisesWithHttpInfo (string startDate = null, string endDate = null, decimal? epsActualGreater = null, decimal? epsActualLess = null, decimal? epsMeanEstimateGreater = null, decimal? epsMeanEstimateLess = null, decimal? epsAmountDiffGreater = null, decimal? epsAmountDiffLess = null, decimal? epsPercentDiffGreater = null, decimal? epsPercentDiffLess = null, decimal? epsCountEstimateGreater = null, decimal? epsCountEstimateLess = null, decimal? epsStdDevEstimateGreater = null, decimal? epsStdDevEstimateLess = null, int? pageSize = null, string nextPage = null);
        /// <summary>
        /// Zacks Sales Surprises
        /// </summary>
        /// <remarks>
        /// Returns Zacks sales surprise data for all Securities.
        /// </remarks>
        /// <exception cref="Intrinio.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="startDate">Limit sales surprises to those on or after this date (optional)</param>
        /// <param name="endDate">Limit sales surprises to those on or before this date (optional)</param>
        /// <param name="salesActualGreater">Return only records with an actual sales higher than this value (optional)</param>
        /// <param name="salesActualLess">Return only records with an actual sales lower than this value (optional)</param>
        /// <param name="salesMeanEstimateGreater">Return only records with a sales mean estimate greater than this value (optional)</param>
        /// <param name="salesMeanEstimateLess">Return only records with a sales mean estimate lower than this value (optional)</param>
        /// <param name="salesAmountDiffGreater">Return only records with a sales amount difference greater than this value (optional)</param>
        /// <param name="salesAmountDiffLess">Return only records with a sales amount difference less than this value (optional)</param>
        /// <param name="salesPercentDiffGreater">Return only records with a sales percent difference greater than this value (optional)</param>
        /// <param name="salesPercentDiffLess">Return only records with a sales percent difference less than this value (optional)</param>
        /// <param name="salesCountEstimateGreater">Return only records with a sales count estimate greater than this value (optional)</param>
        /// <param name="salesCountEstimateLess">Return only records with a sales count estimate less than this value (optional)</param>
        /// <param name="salesStdDevEstimateGreater">Return only records with a sales standard deviation greater than this value (optional)</param>
        /// <param name="salesStdDevEstimateLess">Return only records with a sales standard deviation less than this value (optional)</param>
        /// <param name="pageSize">The number of results to return (optional, default to 100)</param>
        /// <param name="nextPage">Gets the next page of data from a previous API call (optional)</param>
        /// <returns>ApiResponseZacksSalesSurprises</returns>
        ApiResponseZacksSalesSurprises GetZacksSalesSurprises (string startDate = null, string endDate = null, decimal? salesActualGreater = null, decimal? salesActualLess = null, decimal? salesMeanEstimateGreater = null, decimal? salesMeanEstimateLess = null, decimal? salesAmountDiffGreater = null, decimal? salesAmountDiffLess = null, decimal? salesPercentDiffGreater = null, decimal? salesPercentDiffLess = null, decimal? salesCountEstimateGreater = null, decimal? salesCountEstimateLess = null, decimal? salesStdDevEstimateGreater = null, decimal? salesStdDevEstimateLess = null, int? pageSize = null, string nextPage = null);

        /// <summary>
        /// Zacks Sales Surprises
        /// </summary>
        /// <remarks>
        /// Returns Zacks sales surprise data for all Securities.
        /// </remarks>
        /// <exception cref="Intrinio.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="startDate">Limit sales surprises to those on or after this date (optional)</param>
        /// <param name="endDate">Limit sales surprises to those on or before this date (optional)</param>
        /// <param name="salesActualGreater">Return only records with an actual sales higher than this value (optional)</param>
        /// <param name="salesActualLess">Return only records with an actual sales lower than this value (optional)</param>
        /// <param name="salesMeanEstimateGreater">Return only records with a sales mean estimate greater than this value (optional)</param>
        /// <param name="salesMeanEstimateLess">Return only records with a sales mean estimate lower than this value (optional)</param>
        /// <param name="salesAmountDiffGreater">Return only records with a sales amount difference greater than this value (optional)</param>
        /// <param name="salesAmountDiffLess">Return only records with a sales amount difference less than this value (optional)</param>
        /// <param name="salesPercentDiffGreater">Return only records with a sales percent difference greater than this value (optional)</param>
        /// <param name="salesPercentDiffLess">Return only records with a sales percent difference less than this value (optional)</param>
        /// <param name="salesCountEstimateGreater">Return only records with a sales count estimate greater than this value (optional)</param>
        /// <param name="salesCountEstimateLess">Return only records with a sales count estimate less than this value (optional)</param>
        /// <param name="salesStdDevEstimateGreater">Return only records with a sales standard deviation greater than this value (optional)</param>
        /// <param name="salesStdDevEstimateLess">Return only records with a sales standard deviation less than this value (optional)</param>
        /// <param name="pageSize">The number of results to return (optional, default to 100)</param>
        /// <param name="nextPage">Gets the next page of data from a previous API call (optional)</param>
        /// <returns>ApiResponse of ApiResponseZacksSalesSurprises</returns>
        ApiResponse<ApiResponseZacksSalesSurprises> GetZacksSalesSurprisesWithHttpInfo (string startDate = null, string endDate = null, decimal? salesActualGreater = null, decimal? salesActualLess = null, decimal? salesMeanEstimateGreater = null, decimal? salesMeanEstimateLess = null, decimal? salesAmountDiffGreater = null, decimal? salesAmountDiffLess = null, decimal? salesPercentDiffGreater = null, decimal? salesPercentDiffLess = null, decimal? salesCountEstimateGreater = null, decimal? salesCountEstimateLess = null, decimal? salesStdDevEstimateGreater = null, decimal? salesStdDevEstimateLess = null, int? pageSize = null, string nextPage = null);
        #endregion Synchronous Operations
        #region Asynchronous Operations
        /// <summary>
        /// Zacks Analyst Ratings
        /// </summary>
        /// <remarks>
        /// Returns buy, sell, and hold recommendations from analysts at brokerages for all companies in the Zacks universe. Zack’s storied research team aggregates and validates the ratings from professional analysts.
        /// </remarks>
        /// <exception cref="Intrinio.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="identifier">A Security identifier (Ticker, FIGI, ISIN, CUSIP, Intrinio ID) (optional)</param>
        /// <param name="startDate">Limit ratings to those on or after this date (optional)</param>
        /// <param name="endDate">Limit ratings to those on or before this date (optional)</param>
        /// <param name="meanGreater">Return only records with a mean (average) higher than this value (optional)</param>
        /// <param name="meanLess">Return only records with a mean (average) lower than this value (optional)</param>
        /// <param name="strongBuysGreater">Return only records with more than this many Strong Buy recommendations (optional)</param>
        /// <param name="strongBuysLess">Return only records with fewer than this many Strong Buy recommendations (optional)</param>
        /// <param name="buysGreater">Return only records with more than this many Buy recommendations (optional)</param>
        /// <param name="buysLess">Return only records with fewer than this many Buy recommendations (optional)</param>
        /// <param name="holdsGreater">Return only records with more than this many Hold recommendations (optional)</param>
        /// <param name="holdsLess">Return only records with fewer than this many Hold recommendations (optional)</param>
        /// <param name="sellsGreater">Return only records with more than this many Sell recommendations (optional)</param>
        /// <param name="sellsLess">Return only records with fewer than this many Sell recommendations (optional)</param>
        /// <param name="strongSellsGreater">Return only records with more than this many Strong Sell recommendations (optional)</param>
        /// <param name="strongSellsLess">Return only records with fewer than this many Strong Sell recommendations (optional)</param>
        /// <param name="totalGreater">Return only records with more than this many recommendations, regardless of type (optional)</param>
        /// <param name="totalLess">Return only records with fewer than this many recommendations, regardless of type (optional)</param>
        /// <param name="pageSize">The number of results to return (optional, default to 100)</param>
        /// <param name="nextPage">Gets the next page of data from a previous API call (optional)</param>
        /// <returns>Task of ApiResponseZacksAnalystRatings</returns>
        System.Threading.Tasks.Task<ApiResponseZacksAnalystRatings> GetZacksAnalystRatingsAsync (string identifier = null, string startDate = null, string endDate = null, decimal? meanGreater = null, decimal? meanLess = null, int? strongBuysGreater = null, int? strongBuysLess = null, int? buysGreater = null, int? buysLess = null, int? holdsGreater = null, int? holdsLess = null, int? sellsGreater = null, int? sellsLess = null, int? strongSellsGreater = null, int? strongSellsLess = null, int? totalGreater = null, int? totalLess = null, int? pageSize = null, string nextPage = null);

        /// <summary>
        /// Zacks Analyst Ratings
        /// </summary>
        /// <remarks>
        /// Returns buy, sell, and hold recommendations from analysts at brokerages for all companies in the Zacks universe. Zack’s storied research team aggregates and validates the ratings from professional analysts.
        /// </remarks>
        /// <exception cref="Intrinio.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="identifier">A Security identifier (Ticker, FIGI, ISIN, CUSIP, Intrinio ID) (optional)</param>
        /// <param name="startDate">Limit ratings to those on or after this date (optional)</param>
        /// <param name="endDate">Limit ratings to those on or before this date (optional)</param>
        /// <param name="meanGreater">Return only records with a mean (average) higher than this value (optional)</param>
        /// <param name="meanLess">Return only records with a mean (average) lower than this value (optional)</param>
        /// <param name="strongBuysGreater">Return only records with more than this many Strong Buy recommendations (optional)</param>
        /// <param name="strongBuysLess">Return only records with fewer than this many Strong Buy recommendations (optional)</param>
        /// <param name="buysGreater">Return only records with more than this many Buy recommendations (optional)</param>
        /// <param name="buysLess">Return only records with fewer than this many Buy recommendations (optional)</param>
        /// <param name="holdsGreater">Return only records with more than this many Hold recommendations (optional)</param>
        /// <param name="holdsLess">Return only records with fewer than this many Hold recommendations (optional)</param>
        /// <param name="sellsGreater">Return only records with more than this many Sell recommendations (optional)</param>
        /// <param name="sellsLess">Return only records with fewer than this many Sell recommendations (optional)</param>
        /// <param name="strongSellsGreater">Return only records with more than this many Strong Sell recommendations (optional)</param>
        /// <param name="strongSellsLess">Return only records with fewer than this many Strong Sell recommendations (optional)</param>
        /// <param name="totalGreater">Return only records with more than this many recommendations, regardless of type (optional)</param>
        /// <param name="totalLess">Return only records with fewer than this many recommendations, regardless of type (optional)</param>
        /// <param name="pageSize">The number of results to return (optional, default to 100)</param>
        /// <param name="nextPage">Gets the next page of data from a previous API call (optional)</param>
        /// <returns>Task of ApiResponse (ApiResponseZacksAnalystRatings)</returns>
        System.Threading.Tasks.Task<ApiResponse<ApiResponseZacksAnalystRatings>> GetZacksAnalystRatingsAsyncWithHttpInfo (string identifier = null, string startDate = null, string endDate = null, decimal? meanGreater = null, decimal? meanLess = null, int? strongBuysGreater = null, int? strongBuysLess = null, int? buysGreater = null, int? buysLess = null, int? holdsGreater = null, int? holdsLess = null, int? sellsGreater = null, int? sellsLess = null, int? strongSellsGreater = null, int? strongSellsLess = null, int? totalGreater = null, int? totalLess = null, int? pageSize = null, string nextPage = null);
        /// <summary>
        /// Zacks EPS Surprises
        /// </summary>
        /// <remarks>
        /// Returns Zacks eps surprise data for all Securities.
        /// </remarks>
        /// <exception cref="Intrinio.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="startDate">Limit EPS surprises to those on or after this date (optional)</param>
        /// <param name="endDate">Limit EPS surprises to those on or before this date (optional)</param>
        /// <param name="epsActualGreater">Return only records with an actual EPS higher than this value (optional)</param>
        /// <param name="epsActualLess">Return only records with an actual EPS lower than this value (optional)</param>
        /// <param name="epsMeanEstimateGreater">Return only records with an EPS mean estimate greater than this value (optional)</param>
        /// <param name="epsMeanEstimateLess">Return only records with an EPS mean estimate lower than this value (optional)</param>
        /// <param name="epsAmountDiffGreater">Return only records with an EPS amount difference greater than this value (optional)</param>
        /// <param name="epsAmountDiffLess">Return only records with an EPS amount difference less than this value (optional)</param>
        /// <param name="epsPercentDiffGreater">Return only records with an EPS percent difference greater than this value (optional)</param>
        /// <param name="epsPercentDiffLess">Return only records with an EPS percent difference less than this value (optional)</param>
        /// <param name="epsCountEstimateGreater">Return only records with an EPS count estimate greater than this value (optional)</param>
        /// <param name="epsCountEstimateLess">Return only records with an EPS count estimate less than this value (optional)</param>
        /// <param name="epsStdDevEstimateGreater">Return only records with an EPS standard deviation greater than this value (optional)</param>
        /// <param name="epsStdDevEstimateLess">Return only records with an EPS standard deviation less than this value (optional)</param>
        /// <param name="pageSize">The number of results to return (optional, default to 100)</param>
        /// <param name="nextPage">Gets the next page of data from a previous API call (optional)</param>
        /// <returns>Task of ApiResponseZacksEPSSurprises</returns>
        System.Threading.Tasks.Task<ApiResponseZacksEPSSurprises> GetZacksEpsSurprisesAsync (string startDate = null, string endDate = null, decimal? epsActualGreater = null, decimal? epsActualLess = null, decimal? epsMeanEstimateGreater = null, decimal? epsMeanEstimateLess = null, decimal? epsAmountDiffGreater = null, decimal? epsAmountDiffLess = null, decimal? epsPercentDiffGreater = null, decimal? epsPercentDiffLess = null, decimal? epsCountEstimateGreater = null, decimal? epsCountEstimateLess = null, decimal? epsStdDevEstimateGreater = null, decimal? epsStdDevEstimateLess = null, int? pageSize = null, string nextPage = null);

        /// <summary>
        /// Zacks EPS Surprises
        /// </summary>
        /// <remarks>
        /// Returns Zacks eps surprise data for all Securities.
        /// </remarks>
        /// <exception cref="Intrinio.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="startDate">Limit EPS surprises to those on or after this date (optional)</param>
        /// <param name="endDate">Limit EPS surprises to those on or before this date (optional)</param>
        /// <param name="epsActualGreater">Return only records with an actual EPS higher than this value (optional)</param>
        /// <param name="epsActualLess">Return only records with an actual EPS lower than this value (optional)</param>
        /// <param name="epsMeanEstimateGreater">Return only records with an EPS mean estimate greater than this value (optional)</param>
        /// <param name="epsMeanEstimateLess">Return only records with an EPS mean estimate lower than this value (optional)</param>
        /// <param name="epsAmountDiffGreater">Return only records with an EPS amount difference greater than this value (optional)</param>
        /// <param name="epsAmountDiffLess">Return only records with an EPS amount difference less than this value (optional)</param>
        /// <param name="epsPercentDiffGreater">Return only records with an EPS percent difference greater than this value (optional)</param>
        /// <param name="epsPercentDiffLess">Return only records with an EPS percent difference less than this value (optional)</param>
        /// <param name="epsCountEstimateGreater">Return only records with an EPS count estimate greater than this value (optional)</param>
        /// <param name="epsCountEstimateLess">Return only records with an EPS count estimate less than this value (optional)</param>
        /// <param name="epsStdDevEstimateGreater">Return only records with an EPS standard deviation greater than this value (optional)</param>
        /// <param name="epsStdDevEstimateLess">Return only records with an EPS standard deviation less than this value (optional)</param>
        /// <param name="pageSize">The number of results to return (optional, default to 100)</param>
        /// <param name="nextPage">Gets the next page of data from a previous API call (optional)</param>
        /// <returns>Task of ApiResponse (ApiResponseZacksEPSSurprises)</returns>
        System.Threading.Tasks.Task<ApiResponse<ApiResponseZacksEPSSurprises>> GetZacksEpsSurprisesAsyncWithHttpInfo (string startDate = null, string endDate = null, decimal? epsActualGreater = null, decimal? epsActualLess = null, decimal? epsMeanEstimateGreater = null, decimal? epsMeanEstimateLess = null, decimal? epsAmountDiffGreater = null, decimal? epsAmountDiffLess = null, decimal? epsPercentDiffGreater = null, decimal? epsPercentDiffLess = null, decimal? epsCountEstimateGreater = null, decimal? epsCountEstimateLess = null, decimal? epsStdDevEstimateGreater = null, decimal? epsStdDevEstimateLess = null, int? pageSize = null, string nextPage = null);
        /// <summary>
        /// Zacks Sales Surprises
        /// </summary>
        /// <remarks>
        /// Returns Zacks sales surprise data for all Securities.
        /// </remarks>
        /// <exception cref="Intrinio.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="startDate">Limit sales surprises to those on or after this date (optional)</param>
        /// <param name="endDate">Limit sales surprises to those on or before this date (optional)</param>
        /// <param name="salesActualGreater">Return only records with an actual sales higher than this value (optional)</param>
        /// <param name="salesActualLess">Return only records with an actual sales lower than this value (optional)</param>
        /// <param name="salesMeanEstimateGreater">Return only records with a sales mean estimate greater than this value (optional)</param>
        /// <param name="salesMeanEstimateLess">Return only records with a sales mean estimate lower than this value (optional)</param>
        /// <param name="salesAmountDiffGreater">Return only records with a sales amount difference greater than this value (optional)</param>
        /// <param name="salesAmountDiffLess">Return only records with a sales amount difference less than this value (optional)</param>
        /// <param name="salesPercentDiffGreater">Return only records with a sales percent difference greater than this value (optional)</param>
        /// <param name="salesPercentDiffLess">Return only records with a sales percent difference less than this value (optional)</param>
        /// <param name="salesCountEstimateGreater">Return only records with a sales count estimate greater than this value (optional)</param>
        /// <param name="salesCountEstimateLess">Return only records with a sales count estimate less than this value (optional)</param>
        /// <param name="salesStdDevEstimateGreater">Return only records with a sales standard deviation greater than this value (optional)</param>
        /// <param name="salesStdDevEstimateLess">Return only records with a sales standard deviation less than this value (optional)</param>
        /// <param name="pageSize">The number of results to return (optional, default to 100)</param>
        /// <param name="nextPage">Gets the next page of data from a previous API call (optional)</param>
        /// <returns>Task of ApiResponseZacksSalesSurprises</returns>
        System.Threading.Tasks.Task<ApiResponseZacksSalesSurprises> GetZacksSalesSurprisesAsync (string startDate = null, string endDate = null, decimal? salesActualGreater = null, decimal? salesActualLess = null, decimal? salesMeanEstimateGreater = null, decimal? salesMeanEstimateLess = null, decimal? salesAmountDiffGreater = null, decimal? salesAmountDiffLess = null, decimal? salesPercentDiffGreater = null, decimal? salesPercentDiffLess = null, decimal? salesCountEstimateGreater = null, decimal? salesCountEstimateLess = null, decimal? salesStdDevEstimateGreater = null, decimal? salesStdDevEstimateLess = null, int? pageSize = null, string nextPage = null);

        /// <summary>
        /// Zacks Sales Surprises
        /// </summary>
        /// <remarks>
        /// Returns Zacks sales surprise data for all Securities.
        /// </remarks>
        /// <exception cref="Intrinio.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="startDate">Limit sales surprises to those on or after this date (optional)</param>
        /// <param name="endDate">Limit sales surprises to those on or before this date (optional)</param>
        /// <param name="salesActualGreater">Return only records with an actual sales higher than this value (optional)</param>
        /// <param name="salesActualLess">Return only records with an actual sales lower than this value (optional)</param>
        /// <param name="salesMeanEstimateGreater">Return only records with a sales mean estimate greater than this value (optional)</param>
        /// <param name="salesMeanEstimateLess">Return only records with a sales mean estimate lower than this value (optional)</param>
        /// <param name="salesAmountDiffGreater">Return only records with a sales amount difference greater than this value (optional)</param>
        /// <param name="salesAmountDiffLess">Return only records with a sales amount difference less than this value (optional)</param>
        /// <param name="salesPercentDiffGreater">Return only records with a sales percent difference greater than this value (optional)</param>
        /// <param name="salesPercentDiffLess">Return only records with a sales percent difference less than this value (optional)</param>
        /// <param name="salesCountEstimateGreater">Return only records with a sales count estimate greater than this value (optional)</param>
        /// <param name="salesCountEstimateLess">Return only records with a sales count estimate less than this value (optional)</param>
        /// <param name="salesStdDevEstimateGreater">Return only records with a sales standard deviation greater than this value (optional)</param>
        /// <param name="salesStdDevEstimateLess">Return only records with a sales standard deviation less than this value (optional)</param>
        /// <param name="pageSize">The number of results to return (optional, default to 100)</param>
        /// <param name="nextPage">Gets the next page of data from a previous API call (optional)</param>
        /// <returns>Task of ApiResponse (ApiResponseZacksSalesSurprises)</returns>
        System.Threading.Tasks.Task<ApiResponse<ApiResponseZacksSalesSurprises>> GetZacksSalesSurprisesAsyncWithHttpInfo (string startDate = null, string endDate = null, decimal? salesActualGreater = null, decimal? salesActualLess = null, decimal? salesMeanEstimateGreater = null, decimal? salesMeanEstimateLess = null, decimal? salesAmountDiffGreater = null, decimal? salesAmountDiffLess = null, decimal? salesPercentDiffGreater = null, decimal? salesPercentDiffLess = null, decimal? salesCountEstimateGreater = null, decimal? salesCountEstimateLess = null, decimal? salesStdDevEstimateGreater = null, decimal? salesStdDevEstimateLess = null, int? pageSize = null, string nextPage = null);
        #endregion Asynchronous Operations
    }

    /// <summary>
    /// Represents a collection of functions to interact with the API endpoints
    /// </summary>
    public partial class ZacksApi : IZacksApi
    {
        private Intrinio.Client.ExceptionFactory _exceptionFactory = (name, response) => null;

        /// <summary>
        /// Initializes a new instance of the <see cref="ZacksApi"/> class.
        /// </summary>
        /// <returns></returns>
        public ZacksApi(String basePath)
        {
            this.Configuration = new Configuration { BasePath = basePath };

            ExceptionFactory = Intrinio.Client.Configuration.DefaultExceptionFactory;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="ZacksApi"/> class
        /// using Configuration object
        /// </summary>
        /// <param name="configuration">An instance of Configuration</param>
        /// <returns></returns>
        public ZacksApi(Configuration configuration = null)
        {
            if (configuration == null) // use the default one in Configuration
                this.Configuration = Configuration.Default;
            else
                this.Configuration = configuration;

            ExceptionFactory = Intrinio.Client.Configuration.DefaultExceptionFactory;
        }

        /// <summary>
        /// Gets the base path of the API client.
        /// </summary>
        /// <value>The base path</value>
        public String GetBasePath()
        {
            return this.Configuration.ApiClient.RestClient.BaseUrl.ToString();
        }

        /// <summary>
        /// Sets the base path of the API client.
        /// </summary>
        /// <value>The base path</value>
        [Obsolete("SetBasePath is deprecated, please do 'Configuration.ApiClient = new ApiClient(\"http://new-path\")' instead.")]
        public void SetBasePath(String basePath)
        {
            // do nothing
        }

        /// <summary>
        /// Gets or sets the configuration object
        /// </summary>
        /// <value>An instance of the Configuration</value>
        public Configuration Configuration {get; set;}

        /// <summary>
        /// Provides a factory method hook for the creation of exceptions.
        /// </summary>
        public Intrinio.Client.ExceptionFactory ExceptionFactory
        {
            get
            {
                if (_exceptionFactory != null && _exceptionFactory.GetInvocationList().Length > 1)
                {
                    throw new InvalidOperationException("Multicast delegate for ExceptionFactory is unsupported.");
                }
                return _exceptionFactory;
            }
            set { _exceptionFactory = value; }
        }

        /// <summary>
        /// Gets the default header.
        /// </summary>
        /// <returns>Dictionary of HTTP header</returns>
        [Obsolete("DefaultHeader is deprecated, please use Configuration.DefaultHeader instead.")]
        public IDictionary<String, String> DefaultHeader()
        {
            return new ReadOnlyDictionary<string, string>(this.Configuration.DefaultHeader);
        }

        /// <summary>
        /// Add default header.
        /// </summary>
        /// <param name="key">Header field name.</param>
        /// <param name="value">Header field value.</param>
        /// <returns></returns>
        [Obsolete("AddDefaultHeader is deprecated, please use Configuration.AddDefaultHeader instead.")]
        public void AddDefaultHeader(string key, string value)
        {
            this.Configuration.AddDefaultHeader(key, value);
        }

        /// <summary>
        /// Zacks Analyst Ratings Returns buy, sell, and hold recommendations from analysts at brokerages for all companies in the Zacks universe. Zack’s storied research team aggregates and validates the ratings from professional analysts.
        /// </summary>
        /// <exception cref="Intrinio.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="identifier">A Security identifier (Ticker, FIGI, ISIN, CUSIP, Intrinio ID) (optional)</param>
        /// <param name="startDate">Limit ratings to those on or after this date (optional)</param>
        /// <param name="endDate">Limit ratings to those on or before this date (optional)</param>
        /// <param name="meanGreater">Return only records with a mean (average) higher than this value (optional)</param>
        /// <param name="meanLess">Return only records with a mean (average) lower than this value (optional)</param>
        /// <param name="strongBuysGreater">Return only records with more than this many Strong Buy recommendations (optional)</param>
        /// <param name="strongBuysLess">Return only records with fewer than this many Strong Buy recommendations (optional)</param>
        /// <param name="buysGreater">Return only records with more than this many Buy recommendations (optional)</param>
        /// <param name="buysLess">Return only records with fewer than this many Buy recommendations (optional)</param>
        /// <param name="holdsGreater">Return only records with more than this many Hold recommendations (optional)</param>
        /// <param name="holdsLess">Return only records with fewer than this many Hold recommendations (optional)</param>
        /// <param name="sellsGreater">Return only records with more than this many Sell recommendations (optional)</param>
        /// <param name="sellsLess">Return only records with fewer than this many Sell recommendations (optional)</param>
        /// <param name="strongSellsGreater">Return only records with more than this many Strong Sell recommendations (optional)</param>
        /// <param name="strongSellsLess">Return only records with fewer than this many Strong Sell recommendations (optional)</param>
        /// <param name="totalGreater">Return only records with more than this many recommendations, regardless of type (optional)</param>
        /// <param name="totalLess">Return only records with fewer than this many recommendations, regardless of type (optional)</param>
        /// <param name="pageSize">The number of results to return (optional, default to 100)</param>
        /// <param name="nextPage">Gets the next page of data from a previous API call (optional)</param>
        /// <returns>ApiResponseZacksAnalystRatings</returns>
        public ApiResponseZacksAnalystRatings GetZacksAnalystRatings (string identifier = null, string startDate = null, string endDate = null, decimal? meanGreater = null, decimal? meanLess = null, int? strongBuysGreater = null, int? strongBuysLess = null, int? buysGreater = null, int? buysLess = null, int? holdsGreater = null, int? holdsLess = null, int? sellsGreater = null, int? sellsLess = null, int? strongSellsGreater = null, int? strongSellsLess = null, int? totalGreater = null, int? totalLess = null, int? pageSize = null, string nextPage = null)
        {
             ApiResponse<ApiResponseZacksAnalystRatings> localVarResponse = GetZacksAnalystRatingsWithHttpInfo(identifier, startDate, endDate, meanGreater, meanLess, strongBuysGreater, strongBuysLess, buysGreater, buysLess, holdsGreater, holdsLess, sellsGreater, sellsLess, strongSellsGreater, strongSellsLess, totalGreater, totalLess, pageSize, nextPage);
             return localVarResponse.Data;
        }

        /// <summary>
        /// Zacks Analyst Ratings Returns buy, sell, and hold recommendations from analysts at brokerages for all companies in the Zacks universe. Zack’s storied research team aggregates and validates the ratings from professional analysts.
        /// </summary>
        /// <exception cref="Intrinio.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="identifier">A Security identifier (Ticker, FIGI, ISIN, CUSIP, Intrinio ID) (optional)</param>
        /// <param name="startDate">Limit ratings to those on or after this date (optional)</param>
        /// <param name="endDate">Limit ratings to those on or before this date (optional)</param>
        /// <param name="meanGreater">Return only records with a mean (average) higher than this value (optional)</param>
        /// <param name="meanLess">Return only records with a mean (average) lower than this value (optional)</param>
        /// <param name="strongBuysGreater">Return only records with more than this many Strong Buy recommendations (optional)</param>
        /// <param name="strongBuysLess">Return only records with fewer than this many Strong Buy recommendations (optional)</param>
        /// <param name="buysGreater">Return only records with more than this many Buy recommendations (optional)</param>
        /// <param name="buysLess">Return only records with fewer than this many Buy recommendations (optional)</param>
        /// <param name="holdsGreater">Return only records with more than this many Hold recommendations (optional)</param>
        /// <param name="holdsLess">Return only records with fewer than this many Hold recommendations (optional)</param>
        /// <param name="sellsGreater">Return only records with more than this many Sell recommendations (optional)</param>
        /// <param name="sellsLess">Return only records with fewer than this many Sell recommendations (optional)</param>
        /// <param name="strongSellsGreater">Return only records with more than this many Strong Sell recommendations (optional)</param>
        /// <param name="strongSellsLess">Return only records with fewer than this many Strong Sell recommendations (optional)</param>
        /// <param name="totalGreater">Return only records with more than this many recommendations, regardless of type (optional)</param>
        /// <param name="totalLess">Return only records with fewer than this many recommendations, regardless of type (optional)</param>
        /// <param name="pageSize">The number of results to return (optional, default to 100)</param>
        /// <param name="nextPage">Gets the next page of data from a previous API call (optional)</param>
        /// <returns>ApiResponse of ApiResponseZacksAnalystRatings</returns>
        public ApiResponse< ApiResponseZacksAnalystRatings > GetZacksAnalystRatingsWithHttpInfo (string identifier = null, string startDate = null, string endDate = null, decimal? meanGreater = null, decimal? meanLess = null, int? strongBuysGreater = null, int? strongBuysLess = null, int? buysGreater = null, int? buysLess = null, int? holdsGreater = null, int? holdsLess = null, int? sellsGreater = null, int? sellsLess = null, int? strongSellsGreater = null, int? strongSellsLess = null, int? totalGreater = null, int? totalLess = null, int? pageSize = null, string nextPage = null)
        {

            var localVarPath = "/zacks/analyst_ratings";
            var localVarPathParams = new Dictionary<String, String>();
            var localVarQueryParams = new List<KeyValuePair<String, String>>();
            var localVarHeaderParams = new Dictionary<String, String>(Configuration.DefaultHeader);
            var localVarFormParams = new Dictionary<String, String>();
            var localVarFileParams = new Dictionary<String, FileParameter>();
            Object localVarPostBody = null;

            // to determine the Content-Type header
            String[] localVarHttpContentTypes = new String[] {
            };
            String localVarHttpContentType = Configuration.ApiClient.SelectHeaderContentType(localVarHttpContentTypes);

            // to determine the Accept header
            String[] localVarHttpHeaderAccepts = new String[] {
                "application/json"
            };
            String localVarHttpHeaderAccept = Configuration.ApiClient.SelectHeaderAccept(localVarHttpHeaderAccepts);
            if (localVarHttpHeaderAccept != null)
                localVarHeaderParams.Add("Accept", localVarHttpHeaderAccept);

            if (identifier != null) localVarQueryParams.AddRange(Configuration.ApiClient.ParameterToKeyValuePairs("", "identifier", identifier)); // query parameter
            if (startDate != null) localVarQueryParams.AddRange(Configuration.ApiClient.ParameterToKeyValuePairs("", "start_date", startDate)); // query parameter
            if (endDate != null) localVarQueryParams.AddRange(Configuration.ApiClient.ParameterToKeyValuePairs("", "end_date", endDate)); // query parameter
            if (meanGreater != null) localVarQueryParams.AddRange(Configuration.ApiClient.ParameterToKeyValuePairs("", "mean_greater", meanGreater)); // query parameter
            if (meanLess != null) localVarQueryParams.AddRange(Configuration.ApiClient.ParameterToKeyValuePairs("", "mean_less", meanLess)); // query parameter
            if (strongBuysGreater != null) localVarQueryParams.AddRange(Configuration.ApiClient.ParameterToKeyValuePairs("", "strong_buys_greater", strongBuysGreater)); // query parameter
            if (strongBuysLess != null) localVarQueryParams.AddRange(Configuration.ApiClient.ParameterToKeyValuePairs("", "strong_buys_less", strongBuysLess)); // query parameter
            if (buysGreater != null) localVarQueryParams.AddRange(Configuration.ApiClient.ParameterToKeyValuePairs("", "buys_greater", buysGreater)); // query parameter
            if (buysLess != null) localVarQueryParams.AddRange(Configuration.ApiClient.ParameterToKeyValuePairs("", "buys_less", buysLess)); // query parameter
            if (holdsGreater != null) localVarQueryParams.AddRange(Configuration.ApiClient.ParameterToKeyValuePairs("", "holds_greater", holdsGreater)); // query parameter
            if (holdsLess != null) localVarQueryParams.AddRange(Configuration.ApiClient.ParameterToKeyValuePairs("", "holds_less", holdsLess)); // query parameter
            if (sellsGreater != null) localVarQueryParams.AddRange(Configuration.ApiClient.ParameterToKeyValuePairs("", "sells_greater", sellsGreater)); // query parameter
            if (sellsLess != null) localVarQueryParams.AddRange(Configuration.ApiClient.ParameterToKeyValuePairs("", "sells_less", sellsLess)); // query parameter
            if (strongSellsGreater != null) localVarQueryParams.AddRange(Configuration.ApiClient.ParameterToKeyValuePairs("", "strong_sells_greater", strongSellsGreater)); // query parameter
            if (strongSellsLess != null) localVarQueryParams.AddRange(Configuration.ApiClient.ParameterToKeyValuePairs("", "strong_sells_less", strongSellsLess)); // query parameter
            if (totalGreater != null) localVarQueryParams.AddRange(Configuration.ApiClient.ParameterToKeyValuePairs("", "total_greater", totalGreater)); // query parameter
            if (totalLess != null) localVarQueryParams.AddRange(Configuration.ApiClient.ParameterToKeyValuePairs("", "total_less", totalLess)); // query parameter
            if (pageSize != null) localVarQueryParams.AddRange(Configuration.ApiClient.ParameterToKeyValuePairs("", "page_size", pageSize)); // query parameter
            if (nextPage != null) localVarQueryParams.AddRange(Configuration.ApiClient.ParameterToKeyValuePairs("", "next_page", nextPage)); // query parameter

            // authentication (ApiKeyAuth) required
            if (!String.IsNullOrEmpty(Configuration.GetApiKeyWithPrefix("api_key")))
            {
                localVarQueryParams.AddRange(Configuration.ApiClient.ParameterToKeyValuePairs("", "api_key", Configuration.GetApiKeyWithPrefix("api_key")));
            }

            // make the HTTP request
            IRestResponse localVarResponse = (IRestResponse) Configuration.ApiClient.CallApi(localVarPath,
                Method.GET, localVarQueryParams, localVarPostBody, localVarHeaderParams, localVarFormParams, localVarFileParams,
                localVarPathParams, localVarHttpContentType);

            int localVarStatusCode = (int) localVarResponse.StatusCode;

            if (ExceptionFactory != null)
            {
                Exception exception = ExceptionFactory("GetZacksAnalystRatings", localVarResponse);
                if (exception != null) throw exception;
            }

            return new ApiResponse<ApiResponseZacksAnalystRatings>(localVarStatusCode,
                localVarResponse.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                (ApiResponseZacksAnalystRatings) Configuration.ApiClient.Deserialize(localVarResponse, typeof(ApiResponseZacksAnalystRatings)));
        }

        /// <summary>
        /// Zacks Analyst Ratings Returns buy, sell, and hold recommendations from analysts at brokerages for all companies in the Zacks universe. Zack’s storied research team aggregates and validates the ratings from professional analysts.
        /// </summary>
        /// <exception cref="Intrinio.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="identifier">A Security identifier (Ticker, FIGI, ISIN, CUSIP, Intrinio ID) (optional)</param>
        /// <param name="startDate">Limit ratings to those on or after this date (optional)</param>
        /// <param name="endDate">Limit ratings to those on or before this date (optional)</param>
        /// <param name="meanGreater">Return only records with a mean (average) higher than this value (optional)</param>
        /// <param name="meanLess">Return only records with a mean (average) lower than this value (optional)</param>
        /// <param name="strongBuysGreater">Return only records with more than this many Strong Buy recommendations (optional)</param>
        /// <param name="strongBuysLess">Return only records with fewer than this many Strong Buy recommendations (optional)</param>
        /// <param name="buysGreater">Return only records with more than this many Buy recommendations (optional)</param>
        /// <param name="buysLess">Return only records with fewer than this many Buy recommendations (optional)</param>
        /// <param name="holdsGreater">Return only records with more than this many Hold recommendations (optional)</param>
        /// <param name="holdsLess">Return only records with fewer than this many Hold recommendations (optional)</param>
        /// <param name="sellsGreater">Return only records with more than this many Sell recommendations (optional)</param>
        /// <param name="sellsLess">Return only records with fewer than this many Sell recommendations (optional)</param>
        /// <param name="strongSellsGreater">Return only records with more than this many Strong Sell recommendations (optional)</param>
        /// <param name="strongSellsLess">Return only records with fewer than this many Strong Sell recommendations (optional)</param>
        /// <param name="totalGreater">Return only records with more than this many recommendations, regardless of type (optional)</param>
        /// <param name="totalLess">Return only records with fewer than this many recommendations, regardless of type (optional)</param>
        /// <param name="pageSize">The number of results to return (optional, default to 100)</param>
        /// <param name="nextPage">Gets the next page of data from a previous API call (optional)</param>
        /// <returns>Task of ApiResponseZacksAnalystRatings</returns>
        public async System.Threading.Tasks.Task<ApiResponseZacksAnalystRatings> GetZacksAnalystRatingsAsync (string identifier = null, string startDate = null, string endDate = null, decimal? meanGreater = null, decimal? meanLess = null, int? strongBuysGreater = null, int? strongBuysLess = null, int? buysGreater = null, int? buysLess = null, int? holdsGreater = null, int? holdsLess = null, int? sellsGreater = null, int? sellsLess = null, int? strongSellsGreater = null, int? strongSellsLess = null, int? totalGreater = null, int? totalLess = null, int? pageSize = null, string nextPage = null)
        {
             ApiResponse<ApiResponseZacksAnalystRatings> localVarResponse = await GetZacksAnalystRatingsAsyncWithHttpInfo(identifier, startDate, endDate, meanGreater, meanLess, strongBuysGreater, strongBuysLess, buysGreater, buysLess, holdsGreater, holdsLess, sellsGreater, sellsLess, strongSellsGreater, strongSellsLess, totalGreater, totalLess, pageSize, nextPage);
             return localVarResponse.Data;

        }

        /// <summary>
        /// Zacks Analyst Ratings Returns buy, sell, and hold recommendations from analysts at brokerages for all companies in the Zacks universe. Zack’s storied research team aggregates and validates the ratings from professional analysts.
        /// </summary>
        /// <exception cref="Intrinio.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="identifier">A Security identifier (Ticker, FIGI, ISIN, CUSIP, Intrinio ID) (optional)</param>
        /// <param name="startDate">Limit ratings to those on or after this date (optional)</param>
        /// <param name="endDate">Limit ratings to those on or before this date (optional)</param>
        /// <param name="meanGreater">Return only records with a mean (average) higher than this value (optional)</param>
        /// <param name="meanLess">Return only records with a mean (average) lower than this value (optional)</param>
        /// <param name="strongBuysGreater">Return only records with more than this many Strong Buy recommendations (optional)</param>
        /// <param name="strongBuysLess">Return only records with fewer than this many Strong Buy recommendations (optional)</param>
        /// <param name="buysGreater">Return only records with more than this many Buy recommendations (optional)</param>
        /// <param name="buysLess">Return only records with fewer than this many Buy recommendations (optional)</param>
        /// <param name="holdsGreater">Return only records with more than this many Hold recommendations (optional)</param>
        /// <param name="holdsLess">Return only records with fewer than this many Hold recommendations (optional)</param>
        /// <param name="sellsGreater">Return only records with more than this many Sell recommendations (optional)</param>
        /// <param name="sellsLess">Return only records with fewer than this many Sell recommendations (optional)</param>
        /// <param name="strongSellsGreater">Return only records with more than this many Strong Sell recommendations (optional)</param>
        /// <param name="strongSellsLess">Return only records with fewer than this many Strong Sell recommendations (optional)</param>
        /// <param name="totalGreater">Return only records with more than this many recommendations, regardless of type (optional)</param>
        /// <param name="totalLess">Return only records with fewer than this many recommendations, regardless of type (optional)</param>
        /// <param name="pageSize">The number of results to return (optional, default to 100)</param>
        /// <param name="nextPage">Gets the next page of data from a previous API call (optional)</param>
        /// <returns>Task of ApiResponse (ApiResponseZacksAnalystRatings)</returns>
        public async System.Threading.Tasks.Task<ApiResponse<ApiResponseZacksAnalystRatings>> GetZacksAnalystRatingsAsyncWithHttpInfo (string identifier = null, string startDate = null, string endDate = null, decimal? meanGreater = null, decimal? meanLess = null, int? strongBuysGreater = null, int? strongBuysLess = null, int? buysGreater = null, int? buysLess = null, int? holdsGreater = null, int? holdsLess = null, int? sellsGreater = null, int? sellsLess = null, int? strongSellsGreater = null, int? strongSellsLess = null, int? totalGreater = null, int? totalLess = null, int? pageSize = null, string nextPage = null)
        {

            var localVarPath = "/zacks/analyst_ratings";
            var localVarPathParams = new Dictionary<String, String>();
            var localVarQueryParams = new List<KeyValuePair<String, String>>();
            var localVarHeaderParams = new Dictionary<String, String>(Configuration.DefaultHeader);
            var localVarFormParams = new Dictionary<String, String>();
            var localVarFileParams = new Dictionary<String, FileParameter>();
            Object localVarPostBody = null;

            // to determine the Content-Type header
            String[] localVarHttpContentTypes = new String[] {
            };
            String localVarHttpContentType = Configuration.ApiClient.SelectHeaderContentType(localVarHttpContentTypes);

            // to determine the Accept header
            String[] localVarHttpHeaderAccepts = new String[] {
                "application/json"
            };
            String localVarHttpHeaderAccept = Configuration.ApiClient.SelectHeaderAccept(localVarHttpHeaderAccepts);
            if (localVarHttpHeaderAccept != null)
                localVarHeaderParams.Add("Accept", localVarHttpHeaderAccept);

            if (identifier != null) localVarQueryParams.AddRange(Configuration.ApiClient.ParameterToKeyValuePairs("", "identifier", identifier)); // query parameter
            if (startDate != null) localVarQueryParams.AddRange(Configuration.ApiClient.ParameterToKeyValuePairs("", "start_date", startDate)); // query parameter
            if (endDate != null) localVarQueryParams.AddRange(Configuration.ApiClient.ParameterToKeyValuePairs("", "end_date", endDate)); // query parameter
            if (meanGreater != null) localVarQueryParams.AddRange(Configuration.ApiClient.ParameterToKeyValuePairs("", "mean_greater", meanGreater)); // query parameter
            if (meanLess != null) localVarQueryParams.AddRange(Configuration.ApiClient.ParameterToKeyValuePairs("", "mean_less", meanLess)); // query parameter
            if (strongBuysGreater != null) localVarQueryParams.AddRange(Configuration.ApiClient.ParameterToKeyValuePairs("", "strong_buys_greater", strongBuysGreater)); // query parameter
            if (strongBuysLess != null) localVarQueryParams.AddRange(Configuration.ApiClient.ParameterToKeyValuePairs("", "strong_buys_less", strongBuysLess)); // query parameter
            if (buysGreater != null) localVarQueryParams.AddRange(Configuration.ApiClient.ParameterToKeyValuePairs("", "buys_greater", buysGreater)); // query parameter
            if (buysLess != null) localVarQueryParams.AddRange(Configuration.ApiClient.ParameterToKeyValuePairs("", "buys_less", buysLess)); // query parameter
            if (holdsGreater != null) localVarQueryParams.AddRange(Configuration.ApiClient.ParameterToKeyValuePairs("", "holds_greater", holdsGreater)); // query parameter
            if (holdsLess != null) localVarQueryParams.AddRange(Configuration.ApiClient.ParameterToKeyValuePairs("", "holds_less", holdsLess)); // query parameter
            if (sellsGreater != null) localVarQueryParams.AddRange(Configuration.ApiClient.ParameterToKeyValuePairs("", "sells_greater", sellsGreater)); // query parameter
            if (sellsLess != null) localVarQueryParams.AddRange(Configuration.ApiClient.ParameterToKeyValuePairs("", "sells_less", sellsLess)); // query parameter
            if (strongSellsGreater != null) localVarQueryParams.AddRange(Configuration.ApiClient.ParameterToKeyValuePairs("", "strong_sells_greater", strongSellsGreater)); // query parameter
            if (strongSellsLess != null) localVarQueryParams.AddRange(Configuration.ApiClient.ParameterToKeyValuePairs("", "strong_sells_less", strongSellsLess)); // query parameter
            if (totalGreater != null) localVarQueryParams.AddRange(Configuration.ApiClient.ParameterToKeyValuePairs("", "total_greater", totalGreater)); // query parameter
            if (totalLess != null) localVarQueryParams.AddRange(Configuration.ApiClient.ParameterToKeyValuePairs("", "total_less", totalLess)); // query parameter
            if (pageSize != null) localVarQueryParams.AddRange(Configuration.ApiClient.ParameterToKeyValuePairs("", "page_size", pageSize)); // query parameter
            if (nextPage != null) localVarQueryParams.AddRange(Configuration.ApiClient.ParameterToKeyValuePairs("", "next_page", nextPage)); // query parameter

            // authentication (ApiKeyAuth) required
            if (!String.IsNullOrEmpty(Configuration.GetApiKeyWithPrefix("api_key")))
            {
                localVarQueryParams.AddRange(Configuration.ApiClient.ParameterToKeyValuePairs("", "api_key", Configuration.GetApiKeyWithPrefix("api_key")));
            }

            // make the HTTP request
            IRestResponse localVarResponse = (IRestResponse) await Configuration.ApiClient.CallApiAsync(localVarPath,
                Method.GET, localVarQueryParams, localVarPostBody, localVarHeaderParams, localVarFormParams, localVarFileParams,
                localVarPathParams, localVarHttpContentType);

            int localVarStatusCode = (int) localVarResponse.StatusCode;

            if (ExceptionFactory != null)
            {
                Exception exception = ExceptionFactory("GetZacksAnalystRatings", localVarResponse);
                if (exception != null) throw exception;
            }

            return new ApiResponse<ApiResponseZacksAnalystRatings>(localVarStatusCode,
                localVarResponse.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                (ApiResponseZacksAnalystRatings) Configuration.ApiClient.Deserialize(localVarResponse, typeof(ApiResponseZacksAnalystRatings)));
        }

        /// <summary>
        /// Zacks EPS Surprises Returns Zacks eps surprise data for all Securities.
        /// </summary>
        /// <exception cref="Intrinio.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="startDate">Limit EPS surprises to those on or after this date (optional)</param>
        /// <param name="endDate">Limit EPS surprises to those on or before this date (optional)</param>
        /// <param name="epsActualGreater">Return only records with an actual EPS higher than this value (optional)</param>
        /// <param name="epsActualLess">Return only records with an actual EPS lower than this value (optional)</param>
        /// <param name="epsMeanEstimateGreater">Return only records with an EPS mean estimate greater than this value (optional)</param>
        /// <param name="epsMeanEstimateLess">Return only records with an EPS mean estimate lower than this value (optional)</param>
        /// <param name="epsAmountDiffGreater">Return only records with an EPS amount difference greater than this value (optional)</param>
        /// <param name="epsAmountDiffLess">Return only records with an EPS amount difference less than this value (optional)</param>
        /// <param name="epsPercentDiffGreater">Return only records with an EPS percent difference greater than this value (optional)</param>
        /// <param name="epsPercentDiffLess">Return only records with an EPS percent difference less than this value (optional)</param>
        /// <param name="epsCountEstimateGreater">Return only records with an EPS count estimate greater than this value (optional)</param>
        /// <param name="epsCountEstimateLess">Return only records with an EPS count estimate less than this value (optional)</param>
        /// <param name="epsStdDevEstimateGreater">Return only records with an EPS standard deviation greater than this value (optional)</param>
        /// <param name="epsStdDevEstimateLess">Return only records with an EPS standard deviation less than this value (optional)</param>
        /// <param name="pageSize">The number of results to return (optional, default to 100)</param>
        /// <param name="nextPage">Gets the next page of data from a previous API call (optional)</param>
        /// <returns>ApiResponseZacksEPSSurprises</returns>
        public ApiResponseZacksEPSSurprises GetZacksEpsSurprises (string startDate = null, string endDate = null, decimal? epsActualGreater = null, decimal? epsActualLess = null, decimal? epsMeanEstimateGreater = null, decimal? epsMeanEstimateLess = null, decimal? epsAmountDiffGreater = null, decimal? epsAmountDiffLess = null, decimal? epsPercentDiffGreater = null, decimal? epsPercentDiffLess = null, decimal? epsCountEstimateGreater = null, decimal? epsCountEstimateLess = null, decimal? epsStdDevEstimateGreater = null, decimal? epsStdDevEstimateLess = null, int? pageSize = null, string nextPage = null)
        {
             ApiResponse<ApiResponseZacksEPSSurprises> localVarResponse = GetZacksEpsSurprisesWithHttpInfo(startDate, endDate, epsActualGreater, epsActualLess, epsMeanEstimateGreater, epsMeanEstimateLess, epsAmountDiffGreater, epsAmountDiffLess, epsPercentDiffGreater, epsPercentDiffLess, epsCountEstimateGreater, epsCountEstimateLess, epsStdDevEstimateGreater, epsStdDevEstimateLess, pageSize, nextPage);
             return localVarResponse.Data;
        }

        /// <summary>
        /// Zacks EPS Surprises Returns Zacks eps surprise data for all Securities.
        /// </summary>
        /// <exception cref="Intrinio.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="startDate">Limit EPS surprises to those on or after this date (optional)</param>
        /// <param name="endDate">Limit EPS surprises to those on or before this date (optional)</param>
        /// <param name="epsActualGreater">Return only records with an actual EPS higher than this value (optional)</param>
        /// <param name="epsActualLess">Return only records with an actual EPS lower than this value (optional)</param>
        /// <param name="epsMeanEstimateGreater">Return only records with an EPS mean estimate greater than this value (optional)</param>
        /// <param name="epsMeanEstimateLess">Return only records with an EPS mean estimate lower than this value (optional)</param>
        /// <param name="epsAmountDiffGreater">Return only records with an EPS amount difference greater than this value (optional)</param>
        /// <param name="epsAmountDiffLess">Return only records with an EPS amount difference less than this value (optional)</param>
        /// <param name="epsPercentDiffGreater">Return only records with an EPS percent difference greater than this value (optional)</param>
        /// <param name="epsPercentDiffLess">Return only records with an EPS percent difference less than this value (optional)</param>
        /// <param name="epsCountEstimateGreater">Return only records with an EPS count estimate greater than this value (optional)</param>
        /// <param name="epsCountEstimateLess">Return only records with an EPS count estimate less than this value (optional)</param>
        /// <param name="epsStdDevEstimateGreater">Return only records with an EPS standard deviation greater than this value (optional)</param>
        /// <param name="epsStdDevEstimateLess">Return only records with an EPS standard deviation less than this value (optional)</param>
        /// <param name="pageSize">The number of results to return (optional, default to 100)</param>
        /// <param name="nextPage">Gets the next page of data from a previous API call (optional)</param>
        /// <returns>ApiResponse of ApiResponseZacksEPSSurprises</returns>
        public ApiResponse< ApiResponseZacksEPSSurprises > GetZacksEpsSurprisesWithHttpInfo (string startDate = null, string endDate = null, decimal? epsActualGreater = null, decimal? epsActualLess = null, decimal? epsMeanEstimateGreater = null, decimal? epsMeanEstimateLess = null, decimal? epsAmountDiffGreater = null, decimal? epsAmountDiffLess = null, decimal? epsPercentDiffGreater = null, decimal? epsPercentDiffLess = null, decimal? epsCountEstimateGreater = null, decimal? epsCountEstimateLess = null, decimal? epsStdDevEstimateGreater = null, decimal? epsStdDevEstimateLess = null, int? pageSize = null, string nextPage = null)
        {

            var localVarPath = "/zacks/eps_surprises";
            var localVarPathParams = new Dictionary<String, String>();
            var localVarQueryParams = new List<KeyValuePair<String, String>>();
            var localVarHeaderParams = new Dictionary<String, String>(Configuration.DefaultHeader);
            var localVarFormParams = new Dictionary<String, String>();
            var localVarFileParams = new Dictionary<String, FileParameter>();
            Object localVarPostBody = null;

            // to determine the Content-Type header
            String[] localVarHttpContentTypes = new String[] {
            };
            String localVarHttpContentType = Configuration.ApiClient.SelectHeaderContentType(localVarHttpContentTypes);

            // to determine the Accept header
            String[] localVarHttpHeaderAccepts = new String[] {
                "application/json"
            };
            String localVarHttpHeaderAccept = Configuration.ApiClient.SelectHeaderAccept(localVarHttpHeaderAccepts);
            if (localVarHttpHeaderAccept != null)
                localVarHeaderParams.Add("Accept", localVarHttpHeaderAccept);

            if (startDate != null) localVarQueryParams.AddRange(Configuration.ApiClient.ParameterToKeyValuePairs("", "start_date", startDate)); // query parameter
            if (endDate != null) localVarQueryParams.AddRange(Configuration.ApiClient.ParameterToKeyValuePairs("", "end_date", endDate)); // query parameter
            if (epsActualGreater != null) localVarQueryParams.AddRange(Configuration.ApiClient.ParameterToKeyValuePairs("", "eps_actual_greater", epsActualGreater)); // query parameter
            if (epsActualLess != null) localVarQueryParams.AddRange(Configuration.ApiClient.ParameterToKeyValuePairs("", "eps_actual_less", epsActualLess)); // query parameter
            if (epsMeanEstimateGreater != null) localVarQueryParams.AddRange(Configuration.ApiClient.ParameterToKeyValuePairs("", "eps_mean_estimate_greater", epsMeanEstimateGreater)); // query parameter
            if (epsMeanEstimateLess != null) localVarQueryParams.AddRange(Configuration.ApiClient.ParameterToKeyValuePairs("", "eps_mean_estimate_less", epsMeanEstimateLess)); // query parameter
            if (epsAmountDiffGreater != null) localVarQueryParams.AddRange(Configuration.ApiClient.ParameterToKeyValuePairs("", "eps_amount_diff_greater", epsAmountDiffGreater)); // query parameter
            if (epsAmountDiffLess != null) localVarQueryParams.AddRange(Configuration.ApiClient.ParameterToKeyValuePairs("", "eps_amount_diff_less", epsAmountDiffLess)); // query parameter
            if (epsPercentDiffGreater != null) localVarQueryParams.AddRange(Configuration.ApiClient.ParameterToKeyValuePairs("", "eps_percent_diff_greater", epsPercentDiffGreater)); // query parameter
            if (epsPercentDiffLess != null) localVarQueryParams.AddRange(Configuration.ApiClient.ParameterToKeyValuePairs("", "eps_percent_diff_less", epsPercentDiffLess)); // query parameter
            if (epsCountEstimateGreater != null) localVarQueryParams.AddRange(Configuration.ApiClient.ParameterToKeyValuePairs("", "eps_count_estimate_greater", epsCountEstimateGreater)); // query parameter
            if (epsCountEstimateLess != null) localVarQueryParams.AddRange(Configuration.ApiClient.ParameterToKeyValuePairs("", "eps_count_estimate_less", epsCountEstimateLess)); // query parameter
            if (epsStdDevEstimateGreater != null) localVarQueryParams.AddRange(Configuration.ApiClient.ParameterToKeyValuePairs("", "eps_std_dev_estimate_greater", epsStdDevEstimateGreater)); // query parameter
            if (epsStdDevEstimateLess != null) localVarQueryParams.AddRange(Configuration.ApiClient.ParameterToKeyValuePairs("", "eps_std_dev_estimate_less", epsStdDevEstimateLess)); // query parameter
            if (pageSize != null) localVarQueryParams.AddRange(Configuration.ApiClient.ParameterToKeyValuePairs("", "page_size", pageSize)); // query parameter
            if (nextPage != null) localVarQueryParams.AddRange(Configuration.ApiClient.ParameterToKeyValuePairs("", "next_page", nextPage)); // query parameter

            // authentication (ApiKeyAuth) required
            if (!String.IsNullOrEmpty(Configuration.GetApiKeyWithPrefix("api_key")))
            {
                localVarQueryParams.AddRange(Configuration.ApiClient.ParameterToKeyValuePairs("", "api_key", Configuration.GetApiKeyWithPrefix("api_key")));
            }

            // make the HTTP request
            IRestResponse localVarResponse = (IRestResponse) Configuration.ApiClient.CallApi(localVarPath,
                Method.GET, localVarQueryParams, localVarPostBody, localVarHeaderParams, localVarFormParams, localVarFileParams,
                localVarPathParams, localVarHttpContentType);

            int localVarStatusCode = (int) localVarResponse.StatusCode;

            if (ExceptionFactory != null)
            {
                Exception exception = ExceptionFactory("GetZacksEpsSurprises", localVarResponse);
                if (exception != null) throw exception;
            }

            return new ApiResponse<ApiResponseZacksEPSSurprises>(localVarStatusCode,
                localVarResponse.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                (ApiResponseZacksEPSSurprises) Configuration.ApiClient.Deserialize(localVarResponse, typeof(ApiResponseZacksEPSSurprises)));
        }

        /// <summary>
        /// Zacks EPS Surprises Returns Zacks eps surprise data for all Securities.
        /// </summary>
        /// <exception cref="Intrinio.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="startDate">Limit EPS surprises to those on or after this date (optional)</param>
        /// <param name="endDate">Limit EPS surprises to those on or before this date (optional)</param>
        /// <param name="epsActualGreater">Return only records with an actual EPS higher than this value (optional)</param>
        /// <param name="epsActualLess">Return only records with an actual EPS lower than this value (optional)</param>
        /// <param name="epsMeanEstimateGreater">Return only records with an EPS mean estimate greater than this value (optional)</param>
        /// <param name="epsMeanEstimateLess">Return only records with an EPS mean estimate lower than this value (optional)</param>
        /// <param name="epsAmountDiffGreater">Return only records with an EPS amount difference greater than this value (optional)</param>
        /// <param name="epsAmountDiffLess">Return only records with an EPS amount difference less than this value (optional)</param>
        /// <param name="epsPercentDiffGreater">Return only records with an EPS percent difference greater than this value (optional)</param>
        /// <param name="epsPercentDiffLess">Return only records with an EPS percent difference less than this value (optional)</param>
        /// <param name="epsCountEstimateGreater">Return only records with an EPS count estimate greater than this value (optional)</param>
        /// <param name="epsCountEstimateLess">Return only records with an EPS count estimate less than this value (optional)</param>
        /// <param name="epsStdDevEstimateGreater">Return only records with an EPS standard deviation greater than this value (optional)</param>
        /// <param name="epsStdDevEstimateLess">Return only records with an EPS standard deviation less than this value (optional)</param>
        /// <param name="pageSize">The number of results to return (optional, default to 100)</param>
        /// <param name="nextPage">Gets the next page of data from a previous API call (optional)</param>
        /// <returns>Task of ApiResponseZacksEPSSurprises</returns>
        public async System.Threading.Tasks.Task<ApiResponseZacksEPSSurprises> GetZacksEpsSurprisesAsync (string startDate = null, string endDate = null, decimal? epsActualGreater = null, decimal? epsActualLess = null, decimal? epsMeanEstimateGreater = null, decimal? epsMeanEstimateLess = null, decimal? epsAmountDiffGreater = null, decimal? epsAmountDiffLess = null, decimal? epsPercentDiffGreater = null, decimal? epsPercentDiffLess = null, decimal? epsCountEstimateGreater = null, decimal? epsCountEstimateLess = null, decimal? epsStdDevEstimateGreater = null, decimal? epsStdDevEstimateLess = null, int? pageSize = null, string nextPage = null)
        {
             ApiResponse<ApiResponseZacksEPSSurprises> localVarResponse = await GetZacksEpsSurprisesAsyncWithHttpInfo(startDate, endDate, epsActualGreater, epsActualLess, epsMeanEstimateGreater, epsMeanEstimateLess, epsAmountDiffGreater, epsAmountDiffLess, epsPercentDiffGreater, epsPercentDiffLess, epsCountEstimateGreater, epsCountEstimateLess, epsStdDevEstimateGreater, epsStdDevEstimateLess, pageSize, nextPage);
             return localVarResponse.Data;

        }

        /// <summary>
        /// Zacks EPS Surprises Returns Zacks eps surprise data for all Securities.
        /// </summary>
        /// <exception cref="Intrinio.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="startDate">Limit EPS surprises to those on or after this date (optional)</param>
        /// <param name="endDate">Limit EPS surprises to those on or before this date (optional)</param>
        /// <param name="epsActualGreater">Return only records with an actual EPS higher than this value (optional)</param>
        /// <param name="epsActualLess">Return only records with an actual EPS lower than this value (optional)</param>
        /// <param name="epsMeanEstimateGreater">Return only records with an EPS mean estimate greater than this value (optional)</param>
        /// <param name="epsMeanEstimateLess">Return only records with an EPS mean estimate lower than this value (optional)</param>
        /// <param name="epsAmountDiffGreater">Return only records with an EPS amount difference greater than this value (optional)</param>
        /// <param name="epsAmountDiffLess">Return only records with an EPS amount difference less than this value (optional)</param>
        /// <param name="epsPercentDiffGreater">Return only records with an EPS percent difference greater than this value (optional)</param>
        /// <param name="epsPercentDiffLess">Return only records with an EPS percent difference less than this value (optional)</param>
        /// <param name="epsCountEstimateGreater">Return only records with an EPS count estimate greater than this value (optional)</param>
        /// <param name="epsCountEstimateLess">Return only records with an EPS count estimate less than this value (optional)</param>
        /// <param name="epsStdDevEstimateGreater">Return only records with an EPS standard deviation greater than this value (optional)</param>
        /// <param name="epsStdDevEstimateLess">Return only records with an EPS standard deviation less than this value (optional)</param>
        /// <param name="pageSize">The number of results to return (optional, default to 100)</param>
        /// <param name="nextPage">Gets the next page of data from a previous API call (optional)</param>
        /// <returns>Task of ApiResponse (ApiResponseZacksEPSSurprises)</returns>
        public async System.Threading.Tasks.Task<ApiResponse<ApiResponseZacksEPSSurprises>> GetZacksEpsSurprisesAsyncWithHttpInfo (string startDate = null, string endDate = null, decimal? epsActualGreater = null, decimal? epsActualLess = null, decimal? epsMeanEstimateGreater = null, decimal? epsMeanEstimateLess = null, decimal? epsAmountDiffGreater = null, decimal? epsAmountDiffLess = null, decimal? epsPercentDiffGreater = null, decimal? epsPercentDiffLess = null, decimal? epsCountEstimateGreater = null, decimal? epsCountEstimateLess = null, decimal? epsStdDevEstimateGreater = null, decimal? epsStdDevEstimateLess = null, int? pageSize = null, string nextPage = null)
        {

            var localVarPath = "/zacks/eps_surprises";
            var localVarPathParams = new Dictionary<String, String>();
            var localVarQueryParams = new List<KeyValuePair<String, String>>();
            var localVarHeaderParams = new Dictionary<String, String>(Configuration.DefaultHeader);
            var localVarFormParams = new Dictionary<String, String>();
            var localVarFileParams = new Dictionary<String, FileParameter>();
            Object localVarPostBody = null;

            // to determine the Content-Type header
            String[] localVarHttpContentTypes = new String[] {
            };
            String localVarHttpContentType = Configuration.ApiClient.SelectHeaderContentType(localVarHttpContentTypes);

            // to determine the Accept header
            String[] localVarHttpHeaderAccepts = new String[] {
                "application/json"
            };
            String localVarHttpHeaderAccept = Configuration.ApiClient.SelectHeaderAccept(localVarHttpHeaderAccepts);
            if (localVarHttpHeaderAccept != null)
                localVarHeaderParams.Add("Accept", localVarHttpHeaderAccept);

            if (startDate != null) localVarQueryParams.AddRange(Configuration.ApiClient.ParameterToKeyValuePairs("", "start_date", startDate)); // query parameter
            if (endDate != null) localVarQueryParams.AddRange(Configuration.ApiClient.ParameterToKeyValuePairs("", "end_date", endDate)); // query parameter
            if (epsActualGreater != null) localVarQueryParams.AddRange(Configuration.ApiClient.ParameterToKeyValuePairs("", "eps_actual_greater", epsActualGreater)); // query parameter
            if (epsActualLess != null) localVarQueryParams.AddRange(Configuration.ApiClient.ParameterToKeyValuePairs("", "eps_actual_less", epsActualLess)); // query parameter
            if (epsMeanEstimateGreater != null) localVarQueryParams.AddRange(Configuration.ApiClient.ParameterToKeyValuePairs("", "eps_mean_estimate_greater", epsMeanEstimateGreater)); // query parameter
            if (epsMeanEstimateLess != null) localVarQueryParams.AddRange(Configuration.ApiClient.ParameterToKeyValuePairs("", "eps_mean_estimate_less", epsMeanEstimateLess)); // query parameter
            if (epsAmountDiffGreater != null) localVarQueryParams.AddRange(Configuration.ApiClient.ParameterToKeyValuePairs("", "eps_amount_diff_greater", epsAmountDiffGreater)); // query parameter
            if (epsAmountDiffLess != null) localVarQueryParams.AddRange(Configuration.ApiClient.ParameterToKeyValuePairs("", "eps_amount_diff_less", epsAmountDiffLess)); // query parameter
            if (epsPercentDiffGreater != null) localVarQueryParams.AddRange(Configuration.ApiClient.ParameterToKeyValuePairs("", "eps_percent_diff_greater", epsPercentDiffGreater)); // query parameter
            if (epsPercentDiffLess != null) localVarQueryParams.AddRange(Configuration.ApiClient.ParameterToKeyValuePairs("", "eps_percent_diff_less", epsPercentDiffLess)); // query parameter
            if (epsCountEstimateGreater != null) localVarQueryParams.AddRange(Configuration.ApiClient.ParameterToKeyValuePairs("", "eps_count_estimate_greater", epsCountEstimateGreater)); // query parameter
            if (epsCountEstimateLess != null) localVarQueryParams.AddRange(Configuration.ApiClient.ParameterToKeyValuePairs("", "eps_count_estimate_less", epsCountEstimateLess)); // query parameter
            if (epsStdDevEstimateGreater != null) localVarQueryParams.AddRange(Configuration.ApiClient.ParameterToKeyValuePairs("", "eps_std_dev_estimate_greater", epsStdDevEstimateGreater)); // query parameter
            if (epsStdDevEstimateLess != null) localVarQueryParams.AddRange(Configuration.ApiClient.ParameterToKeyValuePairs("", "eps_std_dev_estimate_less", epsStdDevEstimateLess)); // query parameter
            if (pageSize != null) localVarQueryParams.AddRange(Configuration.ApiClient.ParameterToKeyValuePairs("", "page_size", pageSize)); // query parameter
            if (nextPage != null) localVarQueryParams.AddRange(Configuration.ApiClient.ParameterToKeyValuePairs("", "next_page", nextPage)); // query parameter

            // authentication (ApiKeyAuth) required
            if (!String.IsNullOrEmpty(Configuration.GetApiKeyWithPrefix("api_key")))
            {
                localVarQueryParams.AddRange(Configuration.ApiClient.ParameterToKeyValuePairs("", "api_key", Configuration.GetApiKeyWithPrefix("api_key")));
            }

            // make the HTTP request
            IRestResponse localVarResponse = (IRestResponse) await Configuration.ApiClient.CallApiAsync(localVarPath,
                Method.GET, localVarQueryParams, localVarPostBody, localVarHeaderParams, localVarFormParams, localVarFileParams,
                localVarPathParams, localVarHttpContentType);

            int localVarStatusCode = (int) localVarResponse.StatusCode;

            if (ExceptionFactory != null)
            {
                Exception exception = ExceptionFactory("GetZacksEpsSurprises", localVarResponse);
                if (exception != null) throw exception;
            }

            return new ApiResponse<ApiResponseZacksEPSSurprises>(localVarStatusCode,
                localVarResponse.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                (ApiResponseZacksEPSSurprises) Configuration.ApiClient.Deserialize(localVarResponse, typeof(ApiResponseZacksEPSSurprises)));
        }

        /// <summary>
        /// Zacks Sales Surprises Returns Zacks sales surprise data for all Securities.
        /// </summary>
        /// <exception cref="Intrinio.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="startDate">Limit sales surprises to those on or after this date (optional)</param>
        /// <param name="endDate">Limit sales surprises to those on or before this date (optional)</param>
        /// <param name="salesActualGreater">Return only records with an actual sales higher than this value (optional)</param>
        /// <param name="salesActualLess">Return only records with an actual sales lower than this value (optional)</param>
        /// <param name="salesMeanEstimateGreater">Return only records with a sales mean estimate greater than this value (optional)</param>
        /// <param name="salesMeanEstimateLess">Return only records with a sales mean estimate lower than this value (optional)</param>
        /// <param name="salesAmountDiffGreater">Return only records with a sales amount difference greater than this value (optional)</param>
        /// <param name="salesAmountDiffLess">Return only records with a sales amount difference less than this value (optional)</param>
        /// <param name="salesPercentDiffGreater">Return only records with a sales percent difference greater than this value (optional)</param>
        /// <param name="salesPercentDiffLess">Return only records with a sales percent difference less than this value (optional)</param>
        /// <param name="salesCountEstimateGreater">Return only records with a sales count estimate greater than this value (optional)</param>
        /// <param name="salesCountEstimateLess">Return only records with a sales count estimate less than this value (optional)</param>
        /// <param name="salesStdDevEstimateGreater">Return only records with a sales standard deviation greater than this value (optional)</param>
        /// <param name="salesStdDevEstimateLess">Return only records with a sales standard deviation less than this value (optional)</param>
        /// <param name="pageSize">The number of results to return (optional, default to 100)</param>
        /// <param name="nextPage">Gets the next page of data from a previous API call (optional)</param>
        /// <returns>ApiResponseZacksSalesSurprises</returns>
        public ApiResponseZacksSalesSurprises GetZacksSalesSurprises (string startDate = null, string endDate = null, decimal? salesActualGreater = null, decimal? salesActualLess = null, decimal? salesMeanEstimateGreater = null, decimal? salesMeanEstimateLess = null, decimal? salesAmountDiffGreater = null, decimal? salesAmountDiffLess = null, decimal? salesPercentDiffGreater = null, decimal? salesPercentDiffLess = null, decimal? salesCountEstimateGreater = null, decimal? salesCountEstimateLess = null, decimal? salesStdDevEstimateGreater = null, decimal? salesStdDevEstimateLess = null, int? pageSize = null, string nextPage = null)
        {
             ApiResponse<ApiResponseZacksSalesSurprises> localVarResponse = GetZacksSalesSurprisesWithHttpInfo(startDate, endDate, salesActualGreater, salesActualLess, salesMeanEstimateGreater, salesMeanEstimateLess, salesAmountDiffGreater, salesAmountDiffLess, salesPercentDiffGreater, salesPercentDiffLess, salesCountEstimateGreater, salesCountEstimateLess, salesStdDevEstimateGreater, salesStdDevEstimateLess, pageSize, nextPage);
             return localVarResponse.Data;
        }

        /// <summary>
        /// Zacks Sales Surprises Returns Zacks sales surprise data for all Securities.
        /// </summary>
        /// <exception cref="Intrinio.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="startDate">Limit sales surprises to those on or after this date (optional)</param>
        /// <param name="endDate">Limit sales surprises to those on or before this date (optional)</param>
        /// <param name="salesActualGreater">Return only records with an actual sales higher than this value (optional)</param>
        /// <param name="salesActualLess">Return only records with an actual sales lower than this value (optional)</param>
        /// <param name="salesMeanEstimateGreater">Return only records with a sales mean estimate greater than this value (optional)</param>
        /// <param name="salesMeanEstimateLess">Return only records with a sales mean estimate lower than this value (optional)</param>
        /// <param name="salesAmountDiffGreater">Return only records with a sales amount difference greater than this value (optional)</param>
        /// <param name="salesAmountDiffLess">Return only records with a sales amount difference less than this value (optional)</param>
        /// <param name="salesPercentDiffGreater">Return only records with a sales percent difference greater than this value (optional)</param>
        /// <param name="salesPercentDiffLess">Return only records with a sales percent difference less than this value (optional)</param>
        /// <param name="salesCountEstimateGreater">Return only records with a sales count estimate greater than this value (optional)</param>
        /// <param name="salesCountEstimateLess">Return only records with a sales count estimate less than this value (optional)</param>
        /// <param name="salesStdDevEstimateGreater">Return only records with a sales standard deviation greater than this value (optional)</param>
        /// <param name="salesStdDevEstimateLess">Return only records with a sales standard deviation less than this value (optional)</param>
        /// <param name="pageSize">The number of results to return (optional, default to 100)</param>
        /// <param name="nextPage">Gets the next page of data from a previous API call (optional)</param>
        /// <returns>ApiResponse of ApiResponseZacksSalesSurprises</returns>
        public ApiResponse< ApiResponseZacksSalesSurprises > GetZacksSalesSurprisesWithHttpInfo (string startDate = null, string endDate = null, decimal? salesActualGreater = null, decimal? salesActualLess = null, decimal? salesMeanEstimateGreater = null, decimal? salesMeanEstimateLess = null, decimal? salesAmountDiffGreater = null, decimal? salesAmountDiffLess = null, decimal? salesPercentDiffGreater = null, decimal? salesPercentDiffLess = null, decimal? salesCountEstimateGreater = null, decimal? salesCountEstimateLess = null, decimal? salesStdDevEstimateGreater = null, decimal? salesStdDevEstimateLess = null, int? pageSize = null, string nextPage = null)
        {

            var localVarPath = "/zacks/sales_surprises";
            var localVarPathParams = new Dictionary<String, String>();
            var localVarQueryParams = new List<KeyValuePair<String, String>>();
            var localVarHeaderParams = new Dictionary<String, String>(Configuration.DefaultHeader);
            var localVarFormParams = new Dictionary<String, String>();
            var localVarFileParams = new Dictionary<String, FileParameter>();
            Object localVarPostBody = null;

            // to determine the Content-Type header
            String[] localVarHttpContentTypes = new String[] {
            };
            String localVarHttpContentType = Configuration.ApiClient.SelectHeaderContentType(localVarHttpContentTypes);

            // to determine the Accept header
            String[] localVarHttpHeaderAccepts = new String[] {
                "application/json"
            };
            String localVarHttpHeaderAccept = Configuration.ApiClient.SelectHeaderAccept(localVarHttpHeaderAccepts);
            if (localVarHttpHeaderAccept != null)
                localVarHeaderParams.Add("Accept", localVarHttpHeaderAccept);

            if (startDate != null) localVarQueryParams.AddRange(Configuration.ApiClient.ParameterToKeyValuePairs("", "start_date", startDate)); // query parameter
            if (endDate != null) localVarQueryParams.AddRange(Configuration.ApiClient.ParameterToKeyValuePairs("", "end_date", endDate)); // query parameter
            if (salesActualGreater != null) localVarQueryParams.AddRange(Configuration.ApiClient.ParameterToKeyValuePairs("", "sales_actual_greater", salesActualGreater)); // query parameter
            if (salesActualLess != null) localVarQueryParams.AddRange(Configuration.ApiClient.ParameterToKeyValuePairs("", "sales_actual_less", salesActualLess)); // query parameter
            if (salesMeanEstimateGreater != null) localVarQueryParams.AddRange(Configuration.ApiClient.ParameterToKeyValuePairs("", "sales_mean_estimate_greater", salesMeanEstimateGreater)); // query parameter
            if (salesMeanEstimateLess != null) localVarQueryParams.AddRange(Configuration.ApiClient.ParameterToKeyValuePairs("", "sales_mean_estimate_less", salesMeanEstimateLess)); // query parameter
            if (salesAmountDiffGreater != null) localVarQueryParams.AddRange(Configuration.ApiClient.ParameterToKeyValuePairs("", "sales_amount_diff_greater", salesAmountDiffGreater)); // query parameter
            if (salesAmountDiffLess != null) localVarQueryParams.AddRange(Configuration.ApiClient.ParameterToKeyValuePairs("", "sales_amount_diff_less", salesAmountDiffLess)); // query parameter
            if (salesPercentDiffGreater != null) localVarQueryParams.AddRange(Configuration.ApiClient.ParameterToKeyValuePairs("", "sales_percent_diff_greater", salesPercentDiffGreater)); // query parameter
            if (salesPercentDiffLess != null) localVarQueryParams.AddRange(Configuration.ApiClient.ParameterToKeyValuePairs("", "sales_percent_diff_less", salesPercentDiffLess)); // query parameter
            if (salesCountEstimateGreater != null) localVarQueryParams.AddRange(Configuration.ApiClient.ParameterToKeyValuePairs("", "sales_count_estimate_greater", salesCountEstimateGreater)); // query parameter
            if (salesCountEstimateLess != null) localVarQueryParams.AddRange(Configuration.ApiClient.ParameterToKeyValuePairs("", "sales_count_estimate_less", salesCountEstimateLess)); // query parameter
            if (salesStdDevEstimateGreater != null) localVarQueryParams.AddRange(Configuration.ApiClient.ParameterToKeyValuePairs("", "sales_std_dev_estimate_greater", salesStdDevEstimateGreater)); // query parameter
            if (salesStdDevEstimateLess != null) localVarQueryParams.AddRange(Configuration.ApiClient.ParameterToKeyValuePairs("", "sales_std_dev_estimate_less", salesStdDevEstimateLess)); // query parameter
            if (pageSize != null) localVarQueryParams.AddRange(Configuration.ApiClient.ParameterToKeyValuePairs("", "page_size", pageSize)); // query parameter
            if (nextPage != null) localVarQueryParams.AddRange(Configuration.ApiClient.ParameterToKeyValuePairs("", "next_page", nextPage)); // query parameter

            // authentication (ApiKeyAuth) required
            if (!String.IsNullOrEmpty(Configuration.GetApiKeyWithPrefix("api_key")))
            {
                localVarQueryParams.AddRange(Configuration.ApiClient.ParameterToKeyValuePairs("", "api_key", Configuration.GetApiKeyWithPrefix("api_key")));
            }

            // make the HTTP request
            IRestResponse localVarResponse = (IRestResponse) Configuration.ApiClient.CallApi(localVarPath,
                Method.GET, localVarQueryParams, localVarPostBody, localVarHeaderParams, localVarFormParams, localVarFileParams,
                localVarPathParams, localVarHttpContentType);

            int localVarStatusCode = (int) localVarResponse.StatusCode;

            if (ExceptionFactory != null)
            {
                Exception exception = ExceptionFactory("GetZacksSalesSurprises", localVarResponse);
                if (exception != null) throw exception;
            }

            return new ApiResponse<ApiResponseZacksSalesSurprises>(localVarStatusCode,
                localVarResponse.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                (ApiResponseZacksSalesSurprises) Configuration.ApiClient.Deserialize(localVarResponse, typeof(ApiResponseZacksSalesSurprises)));
        }

        /// <summary>
        /// Zacks Sales Surprises Returns Zacks sales surprise data for all Securities.
        /// </summary>
        /// <exception cref="Intrinio.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="startDate">Limit sales surprises to those on or after this date (optional)</param>
        /// <param name="endDate">Limit sales surprises to those on or before this date (optional)</param>
        /// <param name="salesActualGreater">Return only records with an actual sales higher than this value (optional)</param>
        /// <param name="salesActualLess">Return only records with an actual sales lower than this value (optional)</param>
        /// <param name="salesMeanEstimateGreater">Return only records with a sales mean estimate greater than this value (optional)</param>
        /// <param name="salesMeanEstimateLess">Return only records with a sales mean estimate lower than this value (optional)</param>
        /// <param name="salesAmountDiffGreater">Return only records with a sales amount difference greater than this value (optional)</param>
        /// <param name="salesAmountDiffLess">Return only records with a sales amount difference less than this value (optional)</param>
        /// <param name="salesPercentDiffGreater">Return only records with a sales percent difference greater than this value (optional)</param>
        /// <param name="salesPercentDiffLess">Return only records with a sales percent difference less than this value (optional)</param>
        /// <param name="salesCountEstimateGreater">Return only records with a sales count estimate greater than this value (optional)</param>
        /// <param name="salesCountEstimateLess">Return only records with a sales count estimate less than this value (optional)</param>
        /// <param name="salesStdDevEstimateGreater">Return only records with a sales standard deviation greater than this value (optional)</param>
        /// <param name="salesStdDevEstimateLess">Return only records with a sales standard deviation less than this value (optional)</param>
        /// <param name="pageSize">The number of results to return (optional, default to 100)</param>
        /// <param name="nextPage">Gets the next page of data from a previous API call (optional)</param>
        /// <returns>Task of ApiResponseZacksSalesSurprises</returns>
        public async System.Threading.Tasks.Task<ApiResponseZacksSalesSurprises> GetZacksSalesSurprisesAsync (string startDate = null, string endDate = null, decimal? salesActualGreater = null, decimal? salesActualLess = null, decimal? salesMeanEstimateGreater = null, decimal? salesMeanEstimateLess = null, decimal? salesAmountDiffGreater = null, decimal? salesAmountDiffLess = null, decimal? salesPercentDiffGreater = null, decimal? salesPercentDiffLess = null, decimal? salesCountEstimateGreater = null, decimal? salesCountEstimateLess = null, decimal? salesStdDevEstimateGreater = null, decimal? salesStdDevEstimateLess = null, int? pageSize = null, string nextPage = null)
        {
             ApiResponse<ApiResponseZacksSalesSurprises> localVarResponse = await GetZacksSalesSurprisesAsyncWithHttpInfo(startDate, endDate, salesActualGreater, salesActualLess, salesMeanEstimateGreater, salesMeanEstimateLess, salesAmountDiffGreater, salesAmountDiffLess, salesPercentDiffGreater, salesPercentDiffLess, salesCountEstimateGreater, salesCountEstimateLess, salesStdDevEstimateGreater, salesStdDevEstimateLess, pageSize, nextPage);
             return localVarResponse.Data;

        }

        /// <summary>
        /// Zacks Sales Surprises Returns Zacks sales surprise data for all Securities.
        /// </summary>
        /// <exception cref="Intrinio.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="startDate">Limit sales surprises to those on or after this date (optional)</param>
        /// <param name="endDate">Limit sales surprises to those on or before this date (optional)</param>
        /// <param name="salesActualGreater">Return only records with an actual sales higher than this value (optional)</param>
        /// <param name="salesActualLess">Return only records with an actual sales lower than this value (optional)</param>
        /// <param name="salesMeanEstimateGreater">Return only records with a sales mean estimate greater than this value (optional)</param>
        /// <param name="salesMeanEstimateLess">Return only records with a sales mean estimate lower than this value (optional)</param>
        /// <param name="salesAmountDiffGreater">Return only records with a sales amount difference greater than this value (optional)</param>
        /// <param name="salesAmountDiffLess">Return only records with a sales amount difference less than this value (optional)</param>
        /// <param name="salesPercentDiffGreater">Return only records with a sales percent difference greater than this value (optional)</param>
        /// <param name="salesPercentDiffLess">Return only records with a sales percent difference less than this value (optional)</param>
        /// <param name="salesCountEstimateGreater">Return only records with a sales count estimate greater than this value (optional)</param>
        /// <param name="salesCountEstimateLess">Return only records with a sales count estimate less than this value (optional)</param>
        /// <param name="salesStdDevEstimateGreater">Return only records with a sales standard deviation greater than this value (optional)</param>
        /// <param name="salesStdDevEstimateLess">Return only records with a sales standard deviation less than this value (optional)</param>
        /// <param name="pageSize">The number of results to return (optional, default to 100)</param>
        /// <param name="nextPage">Gets the next page of data from a previous API call (optional)</param>
        /// <returns>Task of ApiResponse (ApiResponseZacksSalesSurprises)</returns>
        public async System.Threading.Tasks.Task<ApiResponse<ApiResponseZacksSalesSurprises>> GetZacksSalesSurprisesAsyncWithHttpInfo (string startDate = null, string endDate = null, decimal? salesActualGreater = null, decimal? salesActualLess = null, decimal? salesMeanEstimateGreater = null, decimal? salesMeanEstimateLess = null, decimal? salesAmountDiffGreater = null, decimal? salesAmountDiffLess = null, decimal? salesPercentDiffGreater = null, decimal? salesPercentDiffLess = null, decimal? salesCountEstimateGreater = null, decimal? salesCountEstimateLess = null, decimal? salesStdDevEstimateGreater = null, decimal? salesStdDevEstimateLess = null, int? pageSize = null, string nextPage = null)
        {

            var localVarPath = "/zacks/sales_surprises";
            var localVarPathParams = new Dictionary<String, String>();
            var localVarQueryParams = new List<KeyValuePair<String, String>>();
            var localVarHeaderParams = new Dictionary<String, String>(Configuration.DefaultHeader);
            var localVarFormParams = new Dictionary<String, String>();
            var localVarFileParams = new Dictionary<String, FileParameter>();
            Object localVarPostBody = null;

            // to determine the Content-Type header
            String[] localVarHttpContentTypes = new String[] {
            };
            String localVarHttpContentType = Configuration.ApiClient.SelectHeaderContentType(localVarHttpContentTypes);

            // to determine the Accept header
            String[] localVarHttpHeaderAccepts = new String[] {
                "application/json"
            };
            String localVarHttpHeaderAccept = Configuration.ApiClient.SelectHeaderAccept(localVarHttpHeaderAccepts);
            if (localVarHttpHeaderAccept != null)
                localVarHeaderParams.Add("Accept", localVarHttpHeaderAccept);

            if (startDate != null) localVarQueryParams.AddRange(Configuration.ApiClient.ParameterToKeyValuePairs("", "start_date", startDate)); // query parameter
            if (endDate != null) localVarQueryParams.AddRange(Configuration.ApiClient.ParameterToKeyValuePairs("", "end_date", endDate)); // query parameter
            if (salesActualGreater != null) localVarQueryParams.AddRange(Configuration.ApiClient.ParameterToKeyValuePairs("", "sales_actual_greater", salesActualGreater)); // query parameter
            if (salesActualLess != null) localVarQueryParams.AddRange(Configuration.ApiClient.ParameterToKeyValuePairs("", "sales_actual_less", salesActualLess)); // query parameter
            if (salesMeanEstimateGreater != null) localVarQueryParams.AddRange(Configuration.ApiClient.ParameterToKeyValuePairs("", "sales_mean_estimate_greater", salesMeanEstimateGreater)); // query parameter
            if (salesMeanEstimateLess != null) localVarQueryParams.AddRange(Configuration.ApiClient.ParameterToKeyValuePairs("", "sales_mean_estimate_less", salesMeanEstimateLess)); // query parameter
            if (salesAmountDiffGreater != null) localVarQueryParams.AddRange(Configuration.ApiClient.ParameterToKeyValuePairs("", "sales_amount_diff_greater", salesAmountDiffGreater)); // query parameter
            if (salesAmountDiffLess != null) localVarQueryParams.AddRange(Configuration.ApiClient.ParameterToKeyValuePairs("", "sales_amount_diff_less", salesAmountDiffLess)); // query parameter
            if (salesPercentDiffGreater != null) localVarQueryParams.AddRange(Configuration.ApiClient.ParameterToKeyValuePairs("", "sales_percent_diff_greater", salesPercentDiffGreater)); // query parameter
            if (salesPercentDiffLess != null) localVarQueryParams.AddRange(Configuration.ApiClient.ParameterToKeyValuePairs("", "sales_percent_diff_less", salesPercentDiffLess)); // query parameter
            if (salesCountEstimateGreater != null) localVarQueryParams.AddRange(Configuration.ApiClient.ParameterToKeyValuePairs("", "sales_count_estimate_greater", salesCountEstimateGreater)); // query parameter
            if (salesCountEstimateLess != null) localVarQueryParams.AddRange(Configuration.ApiClient.ParameterToKeyValuePairs("", "sales_count_estimate_less", salesCountEstimateLess)); // query parameter
            if (salesStdDevEstimateGreater != null) localVarQueryParams.AddRange(Configuration.ApiClient.ParameterToKeyValuePairs("", "sales_std_dev_estimate_greater", salesStdDevEstimateGreater)); // query parameter
            if (salesStdDevEstimateLess != null) localVarQueryParams.AddRange(Configuration.ApiClient.ParameterToKeyValuePairs("", "sales_std_dev_estimate_less", salesStdDevEstimateLess)); // query parameter
            if (pageSize != null) localVarQueryParams.AddRange(Configuration.ApiClient.ParameterToKeyValuePairs("", "page_size", pageSize)); // query parameter
            if (nextPage != null) localVarQueryParams.AddRange(Configuration.ApiClient.ParameterToKeyValuePairs("", "next_page", nextPage)); // query parameter

            // authentication (ApiKeyAuth) required
            if (!String.IsNullOrEmpty(Configuration.GetApiKeyWithPrefix("api_key")))
            {
                localVarQueryParams.AddRange(Configuration.ApiClient.ParameterToKeyValuePairs("", "api_key", Configuration.GetApiKeyWithPrefix("api_key")));
            }

            // make the HTTP request
            IRestResponse localVarResponse = (IRestResponse) await Configuration.ApiClient.CallApiAsync(localVarPath,
                Method.GET, localVarQueryParams, localVarPostBody, localVarHeaderParams, localVarFormParams, localVarFileParams,
                localVarPathParams, localVarHttpContentType);

            int localVarStatusCode = (int) localVarResponse.StatusCode;

            if (ExceptionFactory != null)
            {
                Exception exception = ExceptionFactory("GetZacksSalesSurprises", localVarResponse);
                if (exception != null) throw exception;
            }

            return new ApiResponse<ApiResponseZacksSalesSurprises>(localVarStatusCode,
                localVarResponse.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                (ApiResponseZacksSalesSurprises) Configuration.ApiClient.Deserialize(localVarResponse, typeof(ApiResponseZacksSalesSurprises)));
        }

    }
}
