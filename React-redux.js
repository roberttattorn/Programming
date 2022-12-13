import React, { Component, ReactDOM } from 'react';
import { render } from 'react-dom';
import { createStore, combineReducers } from 'redux';
import { connect, Provider,useSelector,useDispatch } from 'react-redux';
import './style.css';

<div id="root"></div>

const ADD_ITEM = "ADD_ITEM";
const DELETE_ITEM = "DELETE_ITEM";

const additem=()=>{
  return{
    type:ADD_ITEM,
  };
};
const deleteitem=()=>{
  return{
    type:DELETE_ITEM,
  };
};

const initialState={
  numofitems:0,
}

const cartReducer=(state=initialState,action)=>{
switch(action.type){
  case ADD_ITEM:
    return{
      ...state,
      numofitems:state.numofitems+1,
    }
    case DELETE_ITEM:
    return{
      ...state,
      numofitems:state.numofitems-1,
    }
  default:
    return state;
}
}

const store = createStore(cartReducer);

function Cart () {
  const dispatch = useDispatch();
  const state = useSelector((state) => state);
 return (
 <div className="cart">
 <h2>Number of items in Cart:</h2>
 <button
 onClick={() => {
 dispatch(additem());
 }}
 >
 Add Item to Cart
 </button>
 <button
 disabled={state.numofitems > 0 ? false : true}
 onClick={() => {
 dispatch(deleteitem());
 }}
 >
 Remove Item to Cart
 </button>
 </div>
 );

};



const App = () => {
 
    return (
      <Provider store={store}>
      <Cart/>
        </Provider>
    );
  
};

render(
  <App />,
  document.getElementById("root")
)
