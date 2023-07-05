import { createAsyncThunk, createSlice } from '@reduxjs/toolkit'
import type { PayloadAction } from '@reduxjs/toolkit'
import type { RootState } from '../store'
import {  EnergiesInterface } from '../../types/InterfacesTypes'
import { AllEnergie } from '../../endpoints/energie'

// Define a type for the slice state
interface energieState {
  isLoading: boolean;
  data: EnergiesInterface[] | null;
  isError: boolean;
}

export const fetchEnergies = createAsyncThunk("fetchEnergie", async () => {
  const response = await fetch(AllEnergie);
  return response.json()
})




//Define the initial state using that type
const initialState: energieState = {
  isLoading: false,
  data: null,
  isError: false
}

export const energieSlice = createSlice({
  name: 'energie',
  // `createSlice` will infer the state type from the `initialState` argument
  initialState,
  reducers: {},
  extraReducers: (builder) => {
    builder.addCase(fetchEnergies.pending, (state, action) => {
      state.isLoading = true;
      console.log('pending ' + action)
    });
    builder.addCase(fetchEnergies.fulfilled, (state, action) => {
      state.isLoading = false;
      state.data = action.payload;
      console.log('fuldilled ' + action)

    });
    builder.addCase(fetchEnergies.rejected, (state, action) => {
      console.log('Error', action.payload)
      state.isError =  true
      console.log('rejected ' + action)

    });
  }
});

// export const { } = communeSlice.actions

// Other code such as selectors can use the imported `RootState` type
export const selectEnergie = (state: RootState) => state.energies.data

export default energieSlice.reducer;