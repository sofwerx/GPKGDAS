# Geopackage Data Acquisition Simulator (GPKG DAS) #

## Background ##

The is considerable work being done in geo-spatially enabled applications. This project will attempt to combine the efforts of multiple groups, mainly the OGC. In this project, we'll use NGA Geopackage libraries to generate and edit Geopackages that conform to the OGC standard. We'll also include sample applications that showcase the capabilities of Geopackages, all while solving real world use-cases.

## Goals ##
This Project is a multi stage project that may branch off into their own areas of development

1. Editing Geopackages
2. Using a Simulator as sample visual data for Creating Geopackages
3. Making a Protocol that will allow multiple actors to update Geopackage information to each other

Each Goal will have an assigned use case and test-bench to show whether its efficacy.

More details will come under each of the next sections

### Editing Geopackages ###
The NGA Geopackage Java and JS libraries will be used in system to access geopackage data and perform necessary functions to them.

### Simulating Real World for Visual Data###
The Main Engine for Visualization will be in Unity. The choice of the engine is arbitrary, but it does allow for simplified development of non-essential visuals.
Open-CV will be used to acquire images and process them for useful information about the space.

### Networking Geopackage information ###
Experimental for now. Decentralized Blockchain? Centralized Server?