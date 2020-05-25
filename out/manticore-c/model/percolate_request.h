/*
 * percolate_request.h
 *
 * Object with documents to percolate
 */

#ifndef _percolate_request_H_
#define _percolate_request_H_

#include <string.h>
#include "../external/cJSON.h"
#include "../include/list.h"
#include "../include/keyValuePair.h"
#include "../include/binary.h"

typedef struct percolate_request_t percolate_request_t;

#include "percolate_request_query.h"



typedef struct percolate_request_t {
    struct percolate_request_query_t *query; //model

} percolate_request_t;

percolate_request_t *percolate_request_create(
    percolate_request_query_t *query
);

void percolate_request_free(percolate_request_t *percolate_request);

percolate_request_t *percolate_request_parseFromJSON(cJSON *percolate_requestJSON);

cJSON *percolate_request_convertToJSON(percolate_request_t *percolate_request);

#endif /* _percolate_request_H_ */
