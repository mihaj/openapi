# coding: utf-8

"""
    Manticore Search API

    This is the API for Manticore Search HTTP protocol   # noqa: E501

    The version of the OpenAPI document: 1.0.0
    Contact: info@manticoresearch.com
    Generated by: https://openapi-generator.tech
"""


from __future__ import absolute_import
from pprint import pprint
import unittest
import openapi_client
from openapi_client.api.index_api import IndexApi  # noqa: E501
from openapi_client.rest import ApiException
from parametrized_test_case import ParametrizedTestCase

class TestIndexApi(ParametrizedTestCase):
    """IndexApi unit test stubs"""

    def setUp(self):
        self.api = openapi_client.IndexApi(openapi_client.ApiClient(self.settings['configuration']))  # noqa: E501
        
    def tearDown(self):
        pass

    def test_bulk(self):
        self.assertTrue(True)
        
    def test_delete(self):
        """Test case for delete
 
        Delete a document in an index  # noqa: E501
        """
        
        req_body = {"index":"test","id":1} 
        api_resp = self.api.delete(req_body)
        req_body = {"index":"test","id":2} 
        api_resp = self.api.delete(req_body)
        
        req_body = {"index":"test","id":3} 
        api_resp = self.api.delete(req_body)
        res = {'deleted':  api_resp.deleted, 'id': api_resp.id, 'index': api_resp.index, 'result': api_resp.result}
        expected_res = {'deleted': None, 'id': 3, 'index': 'test', 'result': 'not found'}
        self.assertDictEqual(res, expected_res)
        
        req_body = {"index":"test","query":{"match":{"content":"no match"}}} 
        api_resp = self.api.delete(req_body)
        res = {'deleted':  api_resp.deleted, 'id': api_resp.id, 'index': api_resp.index, 'result': api_resp.result}
        expected_res = {'deleted': 0, 'id': None, 'index': 'test', 'result': None}
        self.assertDictEqual(res, expected_res)
         
        insert_req_body = {"index":"test","id":1,"doc":{"content":"sample content","name":"test doc","cat":"10"}} 
        self.api.insert(insert_req_body)
        req_body = {"index":"test","id":1} 
        api_resp = self.api.delete(req_body)
        res = {'deleted':  api_resp.deleted, 'id': api_resp.id, 'index': api_resp.index, 'result': api_resp.result}
        expected_res = {'deleted': None, 'id': 1, 'index': 'test', 'result': 'deleted'}
        self.assertDictEqual(res, expected_res) 
        
        self.api.insert(insert_req_body)
        req_body = {"index":"test","query":{"match":{"content":"sample content"}}} 
        api_resp = self.api.delete(req_body)
        res = {'deleted':  api_resp.deleted, 'id': api_resp.id, 'index': api_resp.index, 'result': api_resp.result}
        expected_res = {'deleted': 1, 'id': None, 'index': 'test', 'result': None}        
        self.assertDictEqual(res, expected_res)
    
    def test_insert(self):
        """Test case for insert
   
        Create a new document in an index  # noqa: E501
        """
        req_body = {"index":"test","id":1,"doc":{"content":"sample content","name":"test doc","cat":"10"}} 
        api_resp = self.api.insert(req_body)
        res = {'created':  api_resp.created, 'found': api_resp.found, 'id': api_resp.id, 'index': api_resp.index, 'result': api_resp.result}
        expected_res = {'created': True, 'found': None, 'id': 1, 'index': 'test', 'result': 'created'}
        self.assertDictEqual(res, expected_res) 

    def test_replace(self):
        """Test case for replace
 
        Replace new document in an index  # noqa: E501
        """
        req_body = {"index":"test","id":2,"doc":{"content":"content updated","cat":11}} 
        api_resp = self.api.replace(req_body)
        res = {'created':  api_resp.created, 'found': api_resp.found, 'id': api_resp.id, 'index': api_resp.index, 'result': api_resp.result}
        expected_res = {'created': False, 'found': None, 'id': 2, 'index': 'test', 'result': 'updated'}
        self.assertDictEqual(res, expected_res)
        
        req_body = {"index":"test","id":1,"doc":{"content":"content updated","name":"test doc","cat":11}} 
        api_resp = self.api.replace(req_body)
        res = {'created':  api_resp.created, 'found': api_resp.found, 'id': api_resp.id, 'index': api_resp.index, 'result': api_resp.result}
        expected_res = {'created': False, 'found': None, 'id': 1, 'index': 'test', 'result': 'updated'}
        self.assertDictEqual(res, expected_res)
        pass
 
    def test_update(self):
        """Test case for update

        Update a document in an index  # noqa: E501
        """
        req_body = {"index":"test","doc":{"cat":12},"query":{"equals":{"name":"no match"}}}
        api_resp = self.api.update(req_body)
        res = {'index': api_resp.index, 'result': api_resp.result, 'updated': api_resp.updated}
        expected_res = {'index': 'test', 'result': None, 'updated': 0}
        self.assertDictEqual(res, expected_res)
 
        req_body = {"index":"test","id":3, "doc":{"cat":13}} 
        api_resp = self.api.update(req_body)
        res = {'id': api_resp.id, 'index': api_resp.index, 'result': api_resp.result, 'updated': api_resp.updated}
        expected_res = {'id': 3, 'index': 'test', 'result': 'noop', 'updated': None}
        self.assertDictEqual(res, expected_res)
        
         
        req_body = {"index":"test","id":1, "doc":{"cat":11}} 
        api_resp = self.api.update(req_body)
        res = {'id': api_resp.id, 'index': api_resp.index, 'result': api_resp.result, 'updated': api_resp.updated}
        expected_res = {'id': 1, 'index': 'test', 'result': 'updated', 'updated': None}
        self.assertDictEqual(res, expected_res)
         
        req_body = {"index":"test","doc":{"cat":12},"query":{"equals":{"name":"test doc"}}}
        api_resp = self.api.update(req_body)
        res = {'index': api_resp.index, 'result': api_resp.result, 'updated': api_resp.updated}
        expected_res = {'index': 'test', 'result': None, 'updated': 1}
        self.assertDictEqual(res, expected_res) 

if __name__ == '__main__':
    unittest.main()
