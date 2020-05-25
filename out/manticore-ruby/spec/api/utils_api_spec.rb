=begin
#Manticore Search API

#This is the API for Manticore Search HTTP protocol 

The version of the OpenAPI document: 1.0.0
Contact: info@manticoresearch.com
Generated by: https://openapi-generator.tech
OpenAPI Generator version: 5.0.0-SNAPSHOT

=end

require 'spec_helper'
require 'json'

# Unit tests for OpenapiClient::UtilsApi
# Automatically generated by openapi-generator (https://openapi-generator.tech)
# Please update as you see appropriate
describe 'UtilsApi' do
  before do
    # run before each test
    @api_instance = OpenapiClient::UtilsApi.new
  end

  after do
    # run after each test
  end

  describe 'test an instance of UtilsApi' do
    it 'should create an instance of UtilsApi' do
      expect(@api_instance).to be_instance_of(OpenapiClient::UtilsApi)
    end
  end

  # unit tests for sql
  # Perform SQL requests
  # @param query 
  # @param [Hash] opts the optional parameters
  # @option opts [String] :mode 
  # @return [Hash<String, Object>]
  describe 'sql test' do
    it 'should work' do
      # assertion here. ref: https://www.relishapp.com/rspec/rspec-expectations/docs/built-in-matchers
    end
  end

end
