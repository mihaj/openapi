/*
 * Manticore Search API
 *
 * This is the API for Manticore Search HTTP protocol 
 *
 * API version: 1.0.0
 * Contact: info@manticoresearch.com
 * Generated by: OpenAPI Generator (https://openapi-generator.tech)
 */

package openapi
// InsertDocumentRequest Object with document data. 
type InsertDocumentRequest struct {
	// Name of the index
	Index string `json:"index"`
	// Document ID. 
	Id int64 `json:"id,omitempty"`
	// Object with document data 
	Doc map[string]map[string]interface{} `json:"doc"`
}
