/*
 * update_document_request.h
 *
 * Payload for update document
 */

#ifndef _update_document_request_H_
#define _update_document_request_H_

#include <string.h>
#include "../external/cJSON.h"
#include "../include/list.h"
#include "../include/keyValuePair.h"
#include "../include/binary.h"

typedef struct update_document_request_t update_document_request_t;

#include "object.h"



typedef struct update_document_request_t {
    char *index; // string
    list_t* doc; //map
    long id; //numeric
    list_t* query; //map

} update_document_request_t;

update_document_request_t *update_document_request_create(
    char *index,
    list_t* doc,
    long id,
    list_t* query
);

void update_document_request_free(update_document_request_t *update_document_request);

update_document_request_t *update_document_request_parseFromJSON(cJSON *update_document_requestJSON);

cJSON *update_document_request_convertToJSON(update_document_request_t *update_document_request);

#endif /* _update_document_request_H_ */

