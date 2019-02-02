import React, { Component } from 'react'
import { Route, Link, Redirect } from "react-router-dom";

export default ({ component: Component, token, path}) => {
    return (
      <Route render={() => token != null && token != '' ? 
            (
                <Component/>
            ) : (
                <Redirect to={{pathname: "/"}}/>
            ) 
        }
      />
    );
}