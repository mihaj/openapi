/*
 * Manticore Search API
 * This is the API for Manticore Search HTTP protocol 
 *
 * The version of the OpenAPI document: 1.0.0
 * Contact: info@manticoresearch.com
 *
 * NOTE: This class is auto generated by OpenAPI Generator (https://openapi-generator.tech).
 * https://openapi-generator.tech
 * Do not edit the class manually.
 */


package org.openapitools.client.model;

import java.util.Objects;
import java.util.Arrays;
import com.google.gson.TypeAdapter;
import com.google.gson.annotations.JsonAdapter;
import com.google.gson.annotations.SerializedName;
import com.google.gson.stream.JsonReader;
import com.google.gson.stream.JsonWriter;
import io.swagger.annotations.ApiModel;
import io.swagger.annotations.ApiModelProperty;
import java.io.IOException;
import java.util.HashMap;
import java.util.List;
import java.util.Map;

/**
 * Object with documents to percolate
 */
@ApiModel(description = "Object with documents to percolate")
@javax.annotation.Generated(value = "org.openapitools.codegen.languages.JavaClientCodegen", date = "2020-05-25T15:19:00.920Z[GMT]")
public class PercolateRequest {
  public static final String SERIALIZED_NAME_QUERY = "query";
  @SerializedName(SERIALIZED_NAME_QUERY)
  private Map<String, Object> query = new HashMap<String, Object>();


  public PercolateRequest query(Map<String, Object> query) {
    
    this.query = query;
    return this;
  }

  public PercolateRequest putQueryItem(String key, Object queryItem) {
    this.query.put(key, queryItem);
    return this;
  }

   /**
   * Get query
   * @return query
  **/
  @ApiModelProperty(example = "{\"percolate\":{\"document\":{\"title\":\"some text to match\"}}}", required = true, value = "")

  public Map<String, Object> getQuery() {
    return query;
  }


  public void setQuery(Map<String, Object> query) {
    this.query = query;
  }


  @Override
  public boolean equals(java.lang.Object o) {
    if (this == o) {
      return true;
    }
    if (o == null || getClass() != o.getClass()) {
      return false;
    }
    PercolateRequest percolateRequest = (PercolateRequest) o;
    return Objects.equals(this.query, percolateRequest.query);
  }

  @Override
  public int hashCode() {
    return Objects.hash(query);
  }


  @Override
  public String toString() {
    StringBuilder sb = new StringBuilder();
    sb.append("class PercolateRequest {\n");
    sb.append("    query: ").append(toIndentedString(query)).append("\n");
    sb.append("}");
    return sb.toString();
  }

  /**
   * Convert the given object to string with each line indented by 4 spaces
   * (except the first line).
   */
  private String toIndentedString(java.lang.Object o) {
    if (o == null) {
      return "null";
    }
    return o.toString().replace("\n", "\n    ");
  }

}

