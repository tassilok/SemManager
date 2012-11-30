This repository contains the sources of SemManager.

SemManager is an Ontology-Information-System which is a combination of graphDBs and Ontology-Modules.

# System-Components

## Database
The Information-System has multiple database layer:


1. Relational Database (MS-SQL)


2. Ontology datamodel


3. Procedures for read-access to the ontology datamodel


4. Procedures for write-access to the ontology datamodel


5. Procedures for application-dependent read-access to the ontology of the application


6. Transaction-classes (Dot.Net) for transaction control

You will find the T-SQL scripts in the Database folder



## Modules
The Modules are the applications to work with the ontology datastructures:


1. SemManager: The main module is the SemManager to handle the ontology struktures.


2. SchemaModule: With this module the structures for the MS-SQL database can be managed


3. DevelopmentModule: This module enables you to create configurations for the modules, e.g. the ontology-structures which a module can use.
