import { AnyAction, configureStore, ThunkDispatch } from '@reduxjs/toolkit'
import thunkMiddleware from 'redux-thunk';
import { communeSlice } from './features/communeSlice'
import { energieSlice } from './features/energieSlice';
// ...

export const store = configureStore({
  reducer: {
    communes: communeSlice.reducer,
    energies: energieSlice.reducer
  },
  middleware: [thunkMiddleware]
})

// Infer the `RootState` and `AppDispatch` types from the store itself
export type RootState = ReturnType<typeof store.getState>
// Inferred type: {posts: PostsState, comments: CommentsState, users: UsersState}
export type AppDispatch = typeof store.dispatch

export type AppThunkDispatch = ThunkDispatch<RootState, any, AnyAction>;