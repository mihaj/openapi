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
// SearchRequest Payload for search operation
type SearchRequest struct {
	Index string `json:"index"`
	Query map[string]interface{} `json:"query"`
	Limit int32 `json:"limit,omitempty"`
	Offset int32 `json:"offset,omitempty"`
	MaxMatches int32 `json:"max_matches,omitempty"`
	Sort []OneOfstringobject `json:"sort,omitempty"`
	ScriptFields map[string]interface{} `json:"script_fields,omitempty"`
	Highlight map[string]interface{} `json:"highlight,omitempty"`
	Source OneOfstringobject `json:"_source,omitempty"`
	Profile bool `json:"profile,omitempty"`
}