using System;
using System.Collections.Generic;
using System.Text;
using System.Text.Json.Serialization;

namespace Going.Plaid.Options
{
	/// <summary>
	/// 
	/// </summary>
	public class AccountOptions
	{
		/// <summary>
		/// A list of account ids. If provided, the request will be filtered to these accounts.
		/// </summary>
		/// <remarks>An error will be returned if a provided <c>account_id</c> is not associated with the <see cref="Entity.Item"/>.</remarks>
		[JsonPropertyName("account_ids")]
		public string[] AccountIds { get; set; } = null!;
		
		/// <summary>
		/// Indicating the oldest acceptable balance when making a request to /accounts/balance/get.
		/// </summary>
		/// <remarks>This field is only used when the institution is ins_128026 (Capital One), in which case a value must be provided or an INVALID_REQUEST error will be returned. For all other institutions, this field is ignored.</remarks>
		[JsonPropertyName("min_last_updated_datetime")]
		public DateTime? MinLastUpdatedDatetime { get; set;} = null
		
	}
}
