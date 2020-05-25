# OpenAPIClient-php

This is the API for Manticore Search HTTP protocol


This PHP package is automatically generated by the [OpenAPI Generator](https://openapi-generator.tech) project:

- API version: 1.0.0
- Build package: org.openapitools.codegen.languages.PhpClientCodegen

## Requirements

PHP 7.1 and later

## Installation & Usage

### Composer

To install the bindings via [Composer](http://getcomposer.org/), add the following to `composer.json`:

```json
{
  "repositories": [
    {
      "type": "vcs",
      "url": "https://github.com/GIT_USER_ID/GIT_REPO_ID.git"
    }
  ],
  "require": {
    "GIT_USER_ID/GIT_REPO_ID": "*@dev"
  }
}
```

Then run `composer install`

### Manual Installation

Download the files and include `autoload.php`:

```php
    require_once('/path/to/OpenAPIClient-php/vendor/autoload.php');
```

## Tests

To run the unit tests:

```bash
composer install
./vendor/bin/phpunit
```

## Getting Started

Please follow the [installation procedure](#installation--usage) and then run the following:

```php
<?php
require_once(__DIR__ . '/vendor/autoload.php');



$apiInstance = new OpenAPI\Client\Api\IndexApi(
    // If you want use custom http client, pass your client which implements `GuzzleHttp\ClientInterface`.
    // This is optional, `GuzzleHttp\Client` will be used as default.
    new GuzzleHttp\Client()
);
$body = new \stdClass; // object | 

try {
    $result = $apiInstance->bulk($body);
    print_r($result);
} catch (Exception $e) {
    echo 'Exception when calling IndexApi->bulk: ', $e->getMessage(), PHP_EOL;
}

?>
```

## Documentation for API Endpoints

All URIs are relative to *https://virtserver.swaggerhub.com/adriannuta/ManticoreSeach/1.0.0*

Class | Method | HTTP request | Description
------------ | ------------- | ------------- | -------------
*IndexApi* | [**bulk**](docs/Api/IndexApi.md#bulk) | **POST** /json/bulk | Bulk index operations
*IndexApi* | [**delete**](docs/Api/IndexApi.md#delete) | **POST** /json/delete | Delete a document in an index
*IndexApi* | [**insert**](docs/Api/IndexApi.md#insert) | **POST** /json/insert | Create a new document in an index
*IndexApi* | [**replace**](docs/Api/IndexApi.md#replace) | **POST** /json/replace | Replace new document in an index
*IndexApi* | [**update**](docs/Api/IndexApi.md#update) | **POST** /json/update | Update a document in an index
*SearchApi* | [**percolate**](docs/Api/SearchApi.md#percolate) | **POST** /json/pq/search | Perform reverse search on a percolate index
*SearchApi* | [**search**](docs/Api/SearchApi.md#search) | **POST** /json/search | Performs a search
*UtilsApi* | [**sql**](docs/Api/UtilsApi.md#sql) | **POST** /sql | Perform SQL requests


## Documentation For Models

 - [DeleteDocumentRequest](docs/Model/DeleteDocumentRequest.md)
 - [ErrorResponse](docs/Model/ErrorResponse.md)
 - [InlineObject](docs/Model/InlineObject.md)
 - [InsertDocumentRequest](docs/Model/InsertDocumentRequest.md)
 - [PercolateRequest](docs/Model/PercolateRequest.md)
 - [PercolateRequestQuery](docs/Model/PercolateRequestQuery.md)
 - [SearchRequest](docs/Model/SearchRequest.md)
 - [SearchResponse](docs/Model/SearchResponse.md)
 - [SearchResponseHits](docs/Model/SearchResponseHits.md)
 - [SuccessResponse](docs/Model/SuccessResponse.md)
 - [UpdateDocumentRequest](docs/Model/UpdateDocumentRequest.md)


## Documentation For Authorization

All endpoints do not require authorization.

## Author

adrian.nuta@manticoresearch.com
