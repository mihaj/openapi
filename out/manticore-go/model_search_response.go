/*
 * Manticore Search API
 *
 * This is the API for Manticore Search HTTP protocol 
 *
 * API version: 1.0.0
 * Contact: adrian.nuta@manticoresearch.com
 * Generated by: OpenAPI Generator (https://openapi-generator.tech)
 */

package openapi
// SearchResponse Response object of a search request
type SearchResponse struct {
	Took int32 `json:"took,omitempty"`
	TimedOut bool `json:"timed_out,omitempty"`
	Hits SearchResponseHits `json:"hits,omitempty"`
	Profile map[string]interface{} `json:"profile,omitempty"`
}